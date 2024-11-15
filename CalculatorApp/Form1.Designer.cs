using System.Runtime.CompilerServices;

namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            buttonNum7 = new Button();
            buttonNum8 = new Button();
            buttonNum9 = new Button();
            buttonDiv = new Button();
            buttonNum4 = new Button();
            buttonNum5 = new Button();
            buttonNum6 = new Button();
            buttonMulti = new Button();
            bunnotNum1 = new Button();
            buttonNum2 = new Button();
            buttonNum3 = new Button();
            buttonMinus = new Button();
            buttonC = new Button();
            buttonNum0 = new Button();
            buttonEquals = new Button();
            buttonPlus = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F);
            textBox1.Location = new Point(12, 12);
            textBox1.MaxLength = 16;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 59);
            textBox1.TabIndex = 0;
            // 
            // buttonNum7
            // 
            buttonNum7.Location = new Point(12, 77);
            buttonNum7.Name = "buttonNum7";
            buttonNum7.Size = new Size(75, 65);
            buttonNum7.TabIndex = 1;
            buttonNum7.Text = "7";
            buttonNum7.UseVisualStyleBackColor = true;
            buttonNum7.Click += buttonNum7_Click;
            // 
            // buttonNum8
            // 
            buttonNum8.Location = new Point(93, 77);
            buttonNum8.Name = "buttonNum8";
            buttonNum8.Size = new Size(75, 65);
            buttonNum8.TabIndex = 2;
            buttonNum8.Text = "8";
            buttonNum8.UseVisualStyleBackColor = true;
            buttonNum8.Click += buttonNum8_Click;
            // 
            // buttonNum9
            // 
            buttonNum9.Location = new Point(174, 77);
            buttonNum9.Name = "buttonNum9";
            buttonNum9.Size = new Size(75, 65);
            buttonNum9.TabIndex = 3;
            buttonNum9.Text = "9";
            buttonNum9.UseVisualStyleBackColor = true;
            buttonNum9.Click += buttonNum9_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(255, 77);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(75, 65);
            buttonDiv.TabIndex = 4;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // buttonNum4
            // 
            buttonNum4.Location = new Point(12, 147);
            buttonNum4.Name = "buttonNum4";
            buttonNum4.Size = new Size(75, 65);
            buttonNum4.TabIndex = 5;
            buttonNum4.Text = "4";
            buttonNum4.UseVisualStyleBackColor = true;
            buttonNum4.Click += buttonNum4_Click;
            // 
            // buttonNum5
            // 
            buttonNum5.Location = new Point(93, 147);
            buttonNum5.Name = "buttonNum5";
            buttonNum5.Size = new Size(75, 65);
            buttonNum5.TabIndex = 6;
            buttonNum5.Text = "5";
            buttonNum5.UseVisualStyleBackColor = true;
            buttonNum5.Click += buttonNum5_Click;
            // 
            // buttonNum6
            // 
            buttonNum6.Location = new Point(174, 147);
            buttonNum6.Name = "buttonNum6";
            buttonNum6.Size = new Size(75, 65);
            buttonNum6.TabIndex = 7;
            buttonNum6.Text = "6";
            buttonNum6.UseVisualStyleBackColor = true;
            buttonNum6.Click += buttonNum6_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.Location = new Point(255, 148);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(75, 65);
            buttonMulti.TabIndex = 8;
            buttonMulti.Text = "*";
            buttonMulti.UseVisualStyleBackColor = true;
            buttonMulti.Click += buttonMulti_Click;
            // 
            // bunnotNum1
            // 
            bunnotNum1.Location = new Point(12, 218);
            bunnotNum1.Name = "bunnotNum1";
            bunnotNum1.Size = new Size(75, 65);
            bunnotNum1.TabIndex = 9;
            bunnotNum1.Text = "1";
            bunnotNum1.UseVisualStyleBackColor = true;
            bunnotNum1.Click += bunnotNum1_Click;
            // 
            // buttonNum2
            // 
            buttonNum2.Location = new Point(93, 218);
            buttonNum2.Name = "buttonNum2";
            buttonNum2.Size = new Size(75, 65);
            buttonNum2.TabIndex = 10;
            buttonNum2.Text = "2";
            buttonNum2.UseVisualStyleBackColor = true;
            buttonNum2.Click += buttonNum2_Click;
            // 
            // buttonNum3
            // 
            buttonNum3.Location = new Point(174, 218);
            buttonNum3.Name = "buttonNum3";
            buttonNum3.Size = new Size(75, 65);
            buttonNum3.TabIndex = 11;
            buttonNum3.Text = "3";
            buttonNum3.UseVisualStyleBackColor = true;
            buttonNum3.Click += buttonNum3_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(255, 219);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(75, 65);
            buttonMinus.TabIndex = 12;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(12, 289);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(75, 65);
            buttonC.TabIndex = 13;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonNum0
            // 
            buttonNum0.Location = new Point(93, 289);
            buttonNum0.Name = "buttonNum0";
            buttonNum0.Size = new Size(75, 65);
            buttonNum0.TabIndex = 14;
            buttonNum0.Text = "0";
            buttonNum0.UseVisualStyleBackColor = true;
            buttonNum0.Click += buttonNum0_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(174, 289);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(75, 65);
            buttonEquals.TabIndex = 15;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(255, 289);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(75, 65);
            buttonPlus.TabIndex = 16;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 368);
            Controls.Add(buttonPlus);
            Controls.Add(buttonEquals);
            Controls.Add(buttonNum0);
            Controls.Add(buttonC);
            Controls.Add(buttonMinus);
            Controls.Add(buttonNum3);
            Controls.Add(buttonNum2);
            Controls.Add(bunnotNum1);
            Controls.Add(buttonMulti);
            Controls.Add(buttonNum6);
            Controls.Add(buttonNum5);
            Controls.Add(buttonNum4);
            Controls.Add(buttonDiv);
            Controls.Add(buttonNum9);
            Controls.Add(buttonNum8);
            Controls.Add(buttonNum7);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonNum7;
        private Button buttonNum8;
        private Button buttonNum9;
        private Button buttonDiv;
        private Button buttonNum4;
        private Button buttonNum5;
        private Button buttonNum6;
        private Button buttonMulti;
        private Button bunnotNum1;
        private Button buttonNum2;
        private Button buttonNum3;
        private Button buttonMinus;
        private Button buttonC;
        private Button buttonNum0;
        private Button buttonEquals;
        private Button buttonPlus;
    }
}
