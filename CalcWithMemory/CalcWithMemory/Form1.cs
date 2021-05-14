using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWithMemory
{

    public partial class Form1 : Form
    {
        decimal input = 0;
        decimal result = 0;
        bool isDecimalPointUsed = false;
        string action = "";
        decimal memory = 0;
        decimal temp = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button btnNumber = (Button)sender;


            if (tbResult.Text == "0")
            {
                tbResult.Text = btnNumber.Text;
            }
            else
            {
                tbResult.Text += btnNumber.Text;
            }

        }

        private void Calculation()
        {
            input = decimal.Parse(tbResult.Text);
            switch (action)
            {
                case "":
                    result = input;
                    break;
                case "+":
                    result += input;
                    break;
                case "-":
                    result -= input;
                    break;
                case "x":
                    result *= input;
                    break;
                case "/":
                    result /= input;
                    break;
                default:
                    break;
            }
        }
        private void Reset()
        {
            tbResult.Text = "0";
            isDecimalPointUsed = false;
            input = 0;
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            try
            {



                switch (number.Text)
                {
                    case "+/-":
                        tbResult.Text = (decimal.Parse(tbResult.Text) * -1).ToString();
                        break;
                    case ",":
                        if (!isDecimalPointUsed)
                        {
                            tbResult.Text += ",";
                            isDecimalPointUsed = true;
                        }
                        break;

                    case "+":
                        Calculation();
                        action = "+";
                        lblResult.Text = result + " +";
                        Reset();
                        break;
                    case "-":
                        Calculation();
                        action = "-";
                        lblResult.Text = result + " -";
                        Reset();
                        break;
                    case "x":
                        Calculation();
                        action = "x";
                        lblResult.Text = result + " x";
                        Reset();
                        break;
                    case "/":
                        Calculation();
                        action = "/";
                        lblResult.Text = result + " /";
                        Reset();

                        break;
                    case "√x":
                        if (decimal.Parse(tbResult.Text) < 0) { throw new InvalidOperationException(); };
                        Calculation();
                        action = "";
                        lblResult.Text = "√(" + result + ") = ";

                        Reset();
                        tbResult.Text = Math.Round(((decimal)Math.Sqrt((double)result)), 4).ToString();
                        break;
                    case "^2":
                        Calculation();
                        action = "";
                        lblResult.Text = result + "^2 = ";
                        Reset();
                        tbResult.Text = ((decimal)Math.Pow((double)result, 2)).ToString();
                        break;
                    case "1/x":
                        Calculation();
                        action = "";
                        lblResult.Text = "1/" + result + " = ";
                        Reset();
                        tbResult.Text = Math.Round((1 / result), 4).ToString();
                        break;

                    case "=":
                        Calculation();
                        action = "";
                        lblResult.Text = "= " + result;
                        Reset();
                        tbResult.Text = result.ToString();
                        break;

                }
            }

            catch (DivideByZeroException)
            {
                lblResult.Text = "Error: Cannot divide by zero!";
            }
            catch (InvalidOperationException)
            {
                lblResult.Text = "Error: Invalid input or operation!";
            }

            catch (Exception)
            {
                lblResult.Text = "Unknow error!";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tbResult.Text.Length > 1)
            {
                tbResult.Text = tbResult.Text.Remove(tbResult.Text.Length - 1);
            }
            else
            {
                tbResult.Text = "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Reset();
            ResultReset();
        }



        private void ResultReset()
        {
            lblResult.Text = "";
            result = 0;
            action = "";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {

            memory = 0;
            MemoryRoot.Enabled = false;
            btnMemoryClear.Enabled = false;
        }

        private void MemoryRoot_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            tbResult.Text = memory.ToString();
        }

        private void btnMemoryAdd_Click(object sender, EventArgs e)
        {
            memory += decimal.Parse(tbResult.Text);
            MemoryRoot.Enabled = true;
            btnMemoryClear.Enabled = true;
        }

        private void btnMemorySubtract_Click(object sender, EventArgs e)
        {
            memory -= decimal.Parse(tbResult.Text);
        }


    }
}

