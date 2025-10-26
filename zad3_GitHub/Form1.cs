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
        }

        private void InitializeManagedPanels()
        {
            _panels = new List<Panel>
            {
                ContainerPanel,
                SubstancePanel
            };
        }

        private void HidePanelBoxes()
        {
            foreach (var panel in _panels)
            {
                BoxVisiblity(panel, false);
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

        private void BoxVisiblity(Panel panel, bool isVisible)
        {
            foreach (var tb in panel.Controls.OfType<TextBox>())
            {
                tb.Visible = isVisible;
            }
            foreach (var cb in panel.Controls.OfType<ComboBox>())
            {
                cb.Visible = isVisible;
            }
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
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SubstanceVolumeTextBox_TextChanged(object sender, EventArgs e)
        {

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
    }
}
