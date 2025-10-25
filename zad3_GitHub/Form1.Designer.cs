namespace zad3_GitHub
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
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            CalculateButton = new Button();
            ClearButton = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 23);
            textBox1.TabIndex = 0;
            textBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(63, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 1;
            label1.Text = "Container Volume (ml)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(32, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            textBox2.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(63, 103);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 3;
            label2.Text = "Substance Amount (%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(63, 197);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 5;
            label3.Text = "Container Amount";
            // 
            // CalculateButton
            // 
            CalculateButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            CalculateButton.Location = new Point(12, 328);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(178, 142);
            CalculateButton.TabIndex = 6;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += button1_Click;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ClearButton.Location = new Point(220, 328);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(178, 142);
            ClearButton.TabIndex = 7;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 23);
            comboBox1.TabIndex = 8;
            comboBox1.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(32, 159);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 23);
            comboBox2.TabIndex = 9;
            comboBox2.Visible = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.CheckAlign = ContentAlignment.BottomCenter;
            radioButton1.Location = new Point(9, 27);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(123, 32);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Common Containers";
            radioButton1.TextAlign = ContentAlignment.TopCenter;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.CheckAlign = ContentAlignment.BottomCenter;
            radioButton2.Location = new Point(127, 27);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(84, 32);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Manual Input";
            radioButton2.TextAlign = ContentAlignment.TopCenter;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.CheckAlign = ContentAlignment.BottomCenter;
            radioButton3.Location = new Point(12, 121);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(115, 32);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "Common Solutions";
            radioButton3.TextAlign = ContentAlignment.TopCenter;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.CheckAlign = ContentAlignment.BottomCenter;
            radioButton4.Location = new Point(127, 121);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(84, 32);
            radioButton4.TabIndex = 13;
            radioButton4.TabStop = true;
            radioButton4.Text = "Manual Input";
            radioButton4.TextAlign = ContentAlignment.TopCenter;
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(33, 227);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 498);
            Controls.Add(numericUpDown1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(ClearButton);
            Controls.Add(CalculateButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Name = "Form1";
            Text = "Solution Calculator";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button CalculateButton;
        private Button ClearButton;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private NumericUpDown numericUpDown1;
    }
}
