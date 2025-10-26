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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ContainerTextBox = new TextBox();
            VolumeLabel = new Label();
            SubstanceTextBox = new TextBox();
            SubstanceLabel = new Label();
            AmountLabel = new Label();
            CalculateButton = new Button();
            ClearButton = new Button();
            ContainerComboBox = new ComboBox();
            SubstanceComboBox = new ComboBox();
            AmountCounter = new NumericUpDown();
            SolutionVolumeLabel = new Label();
            SolutionVolumeTextBox = new TextBox();
            SubstanceVolumeLabel = new Label();
            SubstanceVolumeTextBox = new TextBox();
            ContainerManualRBut = new RadioButton();
            CommonContainerRBut = new RadioButton();
            SubstanceManualRBut = new RadioButton();
            CommonSolutionRBut = new RadioButton();
            ContainerPanel = new Panel();
            SubstancePanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)AmountCounter).BeginInit();
            ContainerPanel.SuspendLayout();
            SubstancePanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContainerTextBox
            // 
            ContainerTextBox.Location = new Point(22, 48);
            ContainerTextBox.Name = "ContainerTextBox";
            ContainerTextBox.Size = new Size(158, 23);
            ContainerTextBox.TabIndex = 0;
            ContainerTextBox.Visible = false;
            // 
            // VolumeLabel
            // 
            VolumeLabel.AutoSize = true;
            VolumeLabel.BackColor = Color.Transparent;
            VolumeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            VolumeLabel.Location = new Point(13, 9);
            VolumeLabel.Name = "VolumeLabel";
            VolumeLabel.Size = new Size(214, 25);
            VolumeLabel.TabIndex = 1;
            VolumeLabel.Text = "Container Volume (ml)";
            // 
            // SubstanceTextBox
            // 
            SubstanceTextBox.Location = new Point(20, 40);
            SubstanceTextBox.Name = "SubstanceTextBox";
            SubstanceTextBox.Size = new Size(160, 23);
            SubstanceTextBox.TabIndex = 2;
            SubstanceTextBox.Visible = false;
            // 
            // SubstanceLabel
            // 
            SubstanceLabel.AutoSize = true;
            SubstanceLabel.BackColor = Color.Transparent;
            SubstanceLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            SubstanceLabel.Location = new Point(16, 131);
            SubstanceLabel.Name = "SubstanceLabel";
            SubstanceLabel.Size = new Size(211, 25);
            SubstanceLabel.TabIndex = 3;
            SubstanceLabel.Text = "Substance Amount (%)";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.BackColor = Color.Transparent;
            AmountLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            AmountLabel.Location = new Point(32, 234);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(174, 25);
            AmountLabel.TabIndex = 5;
            AmountLabel.Text = "Container Amount";
            // 
            // CalculateButton
            // 
            CalculateButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            CalculateButton.Location = new Point(13, 328);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(230, 142);
            CalculateButton.TabIndex = 6;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ClearButton.Location = new Point(308, 328);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(232, 142);
            ClearButton.TabIndex = 7;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ContainerComboBox
            // 
            ContainerComboBox.FormattingEnabled = true;
            ContainerComboBox.Location = new Point(22, 48);
            ContainerComboBox.Name = "ContainerComboBox";
            ContainerComboBox.Size = new Size(165, 23);
            ContainerComboBox.TabIndex = 8;
            ContainerComboBox.Visible = false;
            // 
            // SubstanceComboBox
            // 
            SubstanceComboBox.FormattingEnabled = true;
            SubstanceComboBox.Location = new Point(20, 41);
            SubstanceComboBox.Name = "SubstanceComboBox";
            SubstanceComboBox.Size = new Size(160, 23);
            SubstanceComboBox.TabIndex = 9;
            SubstanceComboBox.Visible = false;
            // 
            // AmountCounter
            // 
            AmountCounter.Location = new Point(32, 276);
            AmountCounter.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            AmountCounter.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            AmountCounter.Name = "AmountCounter";
            AmountCounter.Size = new Size(120, 23);
            AmountCounter.TabIndex = 14;
            AmountCounter.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SolutionVolumeLabel
            // 
            SolutionVolumeLabel.AutoSize = true;
            SolutionVolumeLabel.BackColor = Color.Transparent;
            SolutionVolumeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            SolutionVolumeLabel.Location = new Point(289, 9);
            SolutionVolumeLabel.Name = "SolutionVolumeLabel";
            SolutionVolumeLabel.Size = new Size(251, 25);
            SolutionVolumeLabel.TabIndex = 15;
            SolutionVolumeLabel.Text = "Total Solution Volume (ml)";
            // 
            // SolutionVolumeTextBox
            // 
            SolutionVolumeTextBox.Enabled = false;
            SolutionVolumeTextBox.Location = new Point(358, 41);
            SolutionVolumeTextBox.Multiline = true;
            SolutionVolumeTextBox.Name = "SolutionVolumeTextBox";
            SolutionVolumeTextBox.ReadOnly = true;
            SolutionVolumeTextBox.Size = new Size(136, 48);
            SolutionVolumeTextBox.TabIndex = 16;
            // 
            // SubstanceVolumeLabel
            // 
            SubstanceVolumeLabel.AutoSize = true;
            SubstanceVolumeLabel.BackColor = Color.Transparent;
            SubstanceVolumeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            SubstanceVolumeLabel.Location = new Point(279, 157);
            SubstanceVolumeLabel.Name = "SubstanceVolumeLabel";
            SubstanceVolumeLabel.Size = new Size(266, 25);
            SubstanceVolumeLabel.TabIndex = 17;
            SubstanceVolumeLabel.Text = "Total Substance Volume (ml)";
            // 
            // SubstanceVolumeTextBox
            // 
            SubstanceVolumeTextBox.Enabled = false;
            SubstanceVolumeTextBox.Location = new Point(358, 197);
            SubstanceVolumeTextBox.Multiline = true;
            SubstanceVolumeTextBox.Name = "SubstanceVolumeTextBox";
            SubstanceVolumeTextBox.ReadOnly = true;
            SubstanceVolumeTextBox.Size = new Size(136, 48);
            SubstanceVolumeTextBox.TabIndex = 18;
            // 
            // ContainerManualRBut
            // 
            ContainerManualRBut.AutoSize = true;
            ContainerManualRBut.BackColor = Color.Transparent;
            ContainerManualRBut.CheckAlign = ContentAlignment.BottomCenter;
            ContainerManualRBut.Location = new Point(131, 10);
            ContainerManualRBut.Name = "ContainerManualRBut";
            ContainerManualRBut.Size = new Size(84, 32);
            ContainerManualRBut.TabIndex = 11;
            ContainerManualRBut.TabStop = true;
            ContainerManualRBut.Text = "Manual Input";
            ContainerManualRBut.TextAlign = ContentAlignment.TopCenter;
            ContainerManualRBut.UseVisualStyleBackColor = false;
            ContainerManualRBut.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // CommonContainerRBut
            // 
            CommonContainerRBut.AutoSize = true;
            CommonContainerRBut.BackColor = Color.Transparent;
            CommonContainerRBut.CheckAlign = ContentAlignment.BottomCenter;
            CommonContainerRBut.Location = new Point(3, 9);
            CommonContainerRBut.Name = "CommonContainerRBut";
            CommonContainerRBut.Size = new Size(123, 32);
            CommonContainerRBut.TabIndex = 10;
            CommonContainerRBut.TabStop = true;
            CommonContainerRBut.Text = "Common Containers";
            CommonContainerRBut.TextAlign = ContentAlignment.TopCenter;
            CommonContainerRBut.UseVisualStyleBackColor = false;
            CommonContainerRBut.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // SubstanceManualRBut
            // 
            SubstanceManualRBut.AutoSize = true;
            SubstanceManualRBut.BackColor = Color.Transparent;
            SubstanceManualRBut.CheckAlign = ContentAlignment.BottomCenter;
            SubstanceManualRBut.Location = new Point(122, 3);
            SubstanceManualRBut.Name = "SubstanceManualRBut";
            SubstanceManualRBut.Size = new Size(84, 32);
            SubstanceManualRBut.TabIndex = 13;
            SubstanceManualRBut.TabStop = true;
            SubstanceManualRBut.Text = "Manual Input";
            SubstanceManualRBut.TextAlign = ContentAlignment.TopCenter;
            SubstanceManualRBut.UseVisualStyleBackColor = false;
            SubstanceManualRBut.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // CommonSolutionRBut
            // 
            CommonSolutionRBut.AutoSize = true;
            CommonSolutionRBut.BackColor = Color.Transparent;
            CommonSolutionRBut.CheckAlign = ContentAlignment.BottomCenter;
            CommonSolutionRBut.Location = new Point(3, 3);
            CommonSolutionRBut.Name = "CommonSolutionRBut";
            CommonSolutionRBut.Size = new Size(115, 32);
            CommonSolutionRBut.TabIndex = 12;
            CommonSolutionRBut.TabStop = true;
            CommonSolutionRBut.Text = "Common Solutions";
            CommonSolutionRBut.TextAlign = ContentAlignment.TopCenter;
            CommonSolutionRBut.UseVisualStyleBackColor = false;
            CommonSolutionRBut.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // ContainerPanel
            // 
            ContainerPanel.BackColor = Color.Transparent;
            ContainerPanel.Controls.Add(CommonContainerRBut);
            ContainerPanel.Controls.Add(ContainerManualRBut);
            ContainerPanel.Controls.Add(ContainerComboBox);
            ContainerPanel.Controls.Add(ContainerTextBox);
            ContainerPanel.Location = new Point(9, 29);
            ContainerPanel.Name = "ContainerPanel";
            ContainerPanel.Size = new Size(218, 87);
            ContainerPanel.TabIndex = 19;
            // 
            // SubstancePanel
            // 
            SubstancePanel.BackColor = Color.Transparent;
            SubstancePanel.Controls.Add(CommonSolutionRBut);
            SubstancePanel.Controls.Add(SubstanceManualRBut);
            SubstancePanel.Controls.Add(SubstanceComboBox);
            SubstancePanel.Controls.Add(SubstanceTextBox);
            SubstancePanel.Location = new Point(16, 157);
            SubstancePanel.Name = "SubstancePanel";
            SubstancePanel.Size = new Size(215, 74);
            SubstancePanel.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(555, 498);
            Controls.Add(SubstanceVolumeTextBox);
            Controls.Add(SubstanceVolumeLabel);
            Controls.Add(SolutionVolumeTextBox);
            Controls.Add(SolutionVolumeLabel);
            Controls.Add(AmountCounter);
            Controls.Add(ClearButton);
            Controls.Add(CalculateButton);
            Controls.Add(AmountLabel);
            Controls.Add(SubstanceLabel);
            Controls.Add(VolumeLabel);
            Controls.Add(ContainerPanel);
            Controls.Add(SubstancePanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Solution Calculator";
            ((System.ComponentModel.ISupportInitialize)AmountCounter).EndInit();
            ContainerPanel.ResumeLayout(false);
            ContainerPanel.PerformLayout();
            SubstancePanel.ResumeLayout(false);
            SubstancePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ContainerTextBox;
        private Label VolumeLabel;
        private TextBox SubstanceTextBox;
        private Label SubstanceLabel;
        private Label AmountLabel;
        private Button CalculateButton;
        private Button ClearButton;
        private ComboBox ContainerComboBox;
        private ComboBox SubstanceComboBox;
        private NumericUpDown AmountCounter;
        private Label SolutionVolumeLabel;
        private TextBox SolutionVolumeTextBox;
        private Label SubstanceVolumeLabel;
        private TextBox SubstanceVolumeTextBox;
        private RadioButton ContainerManualRBut;
        private RadioButton CommonContainerRBut;
        private RadioButton SubstanceManualRBut;
        private RadioButton CommonSolutionRBut;
        private Panel ContainerPanel;
        private Panel SubstancePanel;
    }
}
