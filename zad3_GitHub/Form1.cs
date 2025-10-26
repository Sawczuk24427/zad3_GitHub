using System.Drawing.Imaging;

namespace zad3_GitHub
{
    public partial class Form1 : Form
    {
        private List<Panel> _panels;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            InitializeManagedPanels();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            var containerData = new[]
            {
               ("Glass (500ml)", 500m),
               ("Shot Glass (50ml)", 50m),
               ("Bottle (1000ml)", 1000m),
               ("Cup (250)", 250m)
           };

            var SubstanceData = new[]
            {
                ("Vodka(40%)", 0.4m),
                ("Isopropyl Alcohol(70%)", 0.7m),
                ("Vinegar (10%)", 0.1m),

            };

            ContainerComboBox.Items.AddRange(containerData.Select(cd => cd.Item1).ToArray());
            SubstanceComboBox.Items.AddRange(SubstanceData.Select(sd => sd.Item1).ToArray());
        }

        private void InitializeManagedPanels()
        {
            _panels = new List<Panel>
            {
                ContainerPanel,
                SubstancePanel
            };
        }

        private void BoxVisiblity(Panel panel, bool isVisible)
        {
            foreach (var tb in panel.Controls.OfType<TextBox>())
            {
                tb.Visible = isVisible;
                tb.Clear();
            }
            foreach (var cb in panel.Controls.OfType<ComboBox>())
            {
                cb.Visible = isVisible;
                cb.SelectedIndex = -1;
            }
        }
        private void ClearRadioButtons(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {


                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                if (control.HasChildren)
                {
                    ClearRadioButtons(control.Controls);
                }
            }
        }
        private void HidePanelBoxes()
        {
            foreach (var panel in _panels)
            {
                BoxVisiblity(panel, false);
            }
        }

        private string GetValueFromPanel(Panel panel)
        {
            var visibleTextBox = panel.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Visible);
            if(visibleTextBox != null)
            {
                return visibleTextBox.Text;
            }
            var visibleComboBox = panel.Controls.OfType<ComboBox>().FirstOrDefault(cb => cb.Visible);
            if(visibleComboBox != null && visibleComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                decimal value = selectedItem.Value;
                value *= 100;
                return value.ToString();
            }
            return string.Empty;

        }



        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Image backgroundImage = Properties.Resources.BackgroundImage;

            float opacity = 0.4f;

            using (var brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            if (backgroundImage != null)
            {
                var colorMatrix = new ColorMatrix
                {
                    Matrix33 = opacity
                };
                var imageAttributes = new ImageAttributes();
                imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                var destRect = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);

                e.Graphics.DrawImage(backgroundImage,
                    destRect,
                    0, 0,
                    backgroundImage.Width,
                    backgroundImage.Height,
                    GraphicsUnit.Pixel,
                    imageAttributes);
            }
        }




        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton { Checked: true } checkedButton)
            {
                if (checkedButton.Parent is Panel parentPanel)
                {
                    var textBoxInGroup = parentPanel.Controls.OfType<TextBox>().FirstOrDefault();
                    var comboBoxInGroup = parentPanel.Controls.OfType<ComboBox>().FirstOrDefault();

                    if (textBoxInGroup != null && comboBoxInGroup != null)
                    {
                        bool showTextBox = checkedButton.Name.Contains("Manual");
                        textBoxInGroup.Visible = showTextBox;
                        comboBoxInGroup.Visible = !showTextBox;
                    }
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearRadioButtons(this.Controls);
            HidePanelBoxes();
            AmountCounter.Value = 1;
            SolutionVolumeTextBox.Clear();
            SubstanceVolumeTextBox.Clear();

        }

        private void CalculateButton_Click(object sender, EventArgs e) { 
        //{
        //    string volumeText = GetValueFromPanel(ContainerPanel);
        //    string concentrationText = GetValueFromPanel(SubstancePanel);
        //    string countText = AmountCounter.Value.ToString();

        //    if(TryParseAndCalculate(volumeText, concentrationText, countText, out CalculationResult? result, out string? errorMessage))
        //    {
        //        SolutionVolumeTextBox.Text = result.TotalVolume.ToString("F2") + " ml";
        //        SubstanceVolumeTextBox.Text = result.PureSubstanceVolume.ToString("F2") + " ml";
        //    }
        //    else
        //    {
        //        MessageBox.Show(errorMessage, "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        }
    }
}
