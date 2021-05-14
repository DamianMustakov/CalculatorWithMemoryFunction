
namespace CalcWithMemory
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChangeSign = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDrob = new System.Windows.Forms.Button();
            this.btnSquared = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnMemoryClear = new System.Windows.Forms.Button();
            this.MemoryRoot = new System.Windows.Forms.Button();
            this.btnMemoryAdd = new System.Windows.Forms.Button();
            this.btnMemorySubtract = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangeSign
            // 
            this.btnChangeSign.BackColor = System.Drawing.Color.DarkGray;
            this.btnChangeSign.Location = new System.Drawing.Point(1, 448);
            this.btnChangeSign.Name = "btnChangeSign";
            this.btnChangeSign.Size = new System.Drawing.Size(76, 47);
            this.btnChangeSign.TabIndex = 0;
            this.btnChangeSign.Text = "+/-";
            this.btnChangeSign.UseVisualStyleBackColor = false;
            this.btnChangeSign.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DarkGray;
            this.btn0.Location = new System.Drawing.Point(83, 448);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(76, 47);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.Color.DarkGray;
            this.btnComma.Location = new System.Drawing.Point(165, 448);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(76, 47);
            this.btnComma.TabIndex = 2;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = false;
            this.btnComma.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEquals.Location = new System.Drawing.Point(247, 448);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(76, 47);
            this.btnEquals.TabIndex = 3;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkGray;
            this.btn1.Location = new System.Drawing.Point(1, 395);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(76, 47);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DarkGray;
            this.btn2.Location = new System.Drawing.Point(83, 395);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(76, 47);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DarkGray;
            this.btn3.Location = new System.Drawing.Point(165, 395);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(76, 47);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(247, 395);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(76, 47);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DarkGray;
            this.btn4.Location = new System.Drawing.Point(1, 342);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(76, 47);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DarkGray;
            this.btn5.Location = new System.Drawing.Point(83, 342);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(76, 47);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DarkGray;
            this.btn6.Location = new System.Drawing.Point(165, 342);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(76, 47);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(247, 342);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(76, 47);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DarkGray;
            this.btn7.Location = new System.Drawing.Point(1, 289);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(76, 47);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DarkGray;
            this.btn8.Location = new System.Drawing.Point(83, 289);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(76, 47);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DarkGray;
            this.btn9.Location = new System.Drawing.Point(165, 289);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(76, 47);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(247, 289);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(76, 47);
            this.btnMultiply.TabIndex = 15;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnDrob
            // 
            this.btnDrob.BackColor = System.Drawing.Color.DarkGray;
            this.btnDrob.Location = new System.Drawing.Point(1, 236);
            this.btnDrob.Name = "btnDrob";
            this.btnDrob.Size = new System.Drawing.Size(76, 47);
            this.btnDrob.TabIndex = 16;
            this.btnDrob.Text = "1/x";
            this.btnDrob.UseVisualStyleBackColor = false;
            this.btnDrob.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnSquared
            // 
            this.btnSquared.BackColor = System.Drawing.Color.DarkGray;
            this.btnSquared.Location = new System.Drawing.Point(83, 236);
            this.btnSquared.Name = "btnSquared";
            this.btnSquared.Size = new System.Drawing.Size(76, 47);
            this.btnSquared.TabIndex = 17;
            this.btnSquared.Text = "^2";
            this.btnSquared.UseVisualStyleBackColor = false;
            this.btnSquared.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.DarkGray;
            this.btnSqrt.Location = new System.Drawing.Point(165, 236);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(76, 47);
            this.btnSqrt.TabIndex = 18;
            this.btnSqrt.Text = "√x";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(247, 236);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(76, 47);
            this.btnDivision.TabIndex = 19;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Location = new System.Drawing.Point(1, 183);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(76, 47);
            this.btnClearEntry.TabIndex = 20;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(83, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 47);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(165, 183);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(158, 47);
            this.btnDel.TabIndex = 23;
            this.btnDel.Text = "⌫";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnMemoryClear
            // 
            this.btnMemoryClear.Enabled = false;
            this.btnMemoryClear.Location = new System.Drawing.Point(1, 130);
            this.btnMemoryClear.Name = "btnMemoryClear";
            this.btnMemoryClear.Size = new System.Drawing.Size(76, 47);
            this.btnMemoryClear.TabIndex = 24;
            this.btnMemoryClear.Text = "MC";
            this.btnMemoryClear.UseVisualStyleBackColor = true;
            this.btnMemoryClear.Click += new System.EventHandler(this.btnMemoryClear_Click);
            // 
            // MemoryRoot
            // 
            this.MemoryRoot.Enabled = false;
            this.MemoryRoot.Location = new System.Drawing.Point(83, 130);
            this.MemoryRoot.Name = "MemoryRoot";
            this.MemoryRoot.Size = new System.Drawing.Size(76, 47);
            this.MemoryRoot.TabIndex = 25;
            this.MemoryRoot.Text = "MR";
            this.MemoryRoot.UseVisualStyleBackColor = true;
            this.MemoryRoot.Click += new System.EventHandler(this.MemoryRoot_Click);
            // 
            // btnMemoryAdd
            // 
            this.btnMemoryAdd.Location = new System.Drawing.Point(165, 130);
            this.btnMemoryAdd.Name = "btnMemoryAdd";
            this.btnMemoryAdd.Size = new System.Drawing.Size(76, 47);
            this.btnMemoryAdd.TabIndex = 26;
            this.btnMemoryAdd.Text = "M+";
            this.btnMemoryAdd.UseVisualStyleBackColor = true;
            this.btnMemoryAdd.Click += new System.EventHandler(this.btnMemoryAdd_Click);
            // 
            // btnMemorySubtract
            // 
            this.btnMemorySubtract.Location = new System.Drawing.Point(247, 130);
            this.btnMemorySubtract.Name = "btnMemorySubtract";
            this.btnMemorySubtract.Size = new System.Drawing.Size(76, 47);
            this.btnMemorySubtract.TabIndex = 27;
            this.btnMemorySubtract.Text = "M-";
            this.btnMemorySubtract.UseVisualStyleBackColor = true;
            this.btnMemorySubtract.Click += new System.EventHandler(this.btnMemorySubtract_Click);
            // 
            // tbResult
            // 
            this.tbResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResult.Location = new System.Drawing.Point(1, 44);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(322, 73);
            this.tbResult.TabIndex = 28;
            this.tbResult.Text = "0";
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(12, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResult.Size = new System.Drawing.Size(0, 29);
            this.lblResult.TabIndex = 29;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 496);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnMemorySubtract);
            this.Controls.Add(this.btnMemoryAdd);
            this.Controls.Add(this.MemoryRoot);
            this.Controls.Add(this.btnMemoryClear);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnSquared);
            this.Controls.Add(this.btnDrob);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnChangeSign);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeSign;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDrob;
        private System.Windows.Forms.Button btnSquared;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnMemoryClear;
        private System.Windows.Forms.Button MemoryRoot;
        private System.Windows.Forms.Button btnMemoryAdd;
        private System.Windows.Forms.Button btnMemorySubtract;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lblResult;
    }
}

