using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class LightSettings : UserControl
    {
        // PRIVATE FIELD
        MainForm mainForm;
        Database db;
        // PUBLIC PROPERTIES
        public MainForm MainForm
        {
            set { this.mainForm = value; }
        }
        public Database Db
        {
            set { this.db = value; }
        }
        // CONSTRUCTORS
        public LightSettings()
        {
            InitializeComponent();
        }

        // METHODS

        #region All methods related to changing the light settings
        private void Save()
        {

        }
        #endregion

        #region Updating visuals
        private void UpdateFrontPreview()
        {
            int red = trackBarRedFront.Value;
            int green = trackBarGreenFront.Value;
            int blue = trackBarBlueFront.Value;
            panelColorPreviewFront.BackColor = Color.FromArgb(red, green, blue);
        }
        private void UpdateBackPreview()
        {
            int red = trackBarRedBack.Value;
            int green = trackBarGreenBack.Value;
            int blue = trackBarBlueBack.Value;
            panelColorPreviewBack.BackColor = Color.FromArgb(red, green, blue);
        }

        private void UpdateTabVisuals()
        {
            if (panelLightSettings.Visible && this.mainForm != null)
            {
                if (mainForm.currentLight.OnOffFront)
                {
                    checkBoxLightsFrontDim.Checked = true;
                }
                else
                {
                    checkBoxLightsFrontDim.Checked = false;
                }
                if (mainForm.currentLight.PausePlayFront)
                {
                    checkBoxLightsFrontUndim.Checked = true;
                }
                else
                {
                    checkBoxLightsFrontUndim.Checked = false;
                }
                if (mainForm.currentLight.OnOffBack)
                {
                    checkBoxLightsBackDim.Checked = true;
                }
                else
                {
                    checkBoxLightsBackDim.Checked = false;
                }
                if (mainForm.currentLight.PausePlayBack)
                {
                    checkBoxLightsBackUndim.Checked = true;
                }
                else
                {
                    checkBoxLightsBackUndim.Checked = false;
                }
                trackBarBrightnessFront.Value = mainForm.currentLight.BrightnessFront;
                trackBarRedFront.Value = mainForm.currentLight.ColorFront.R;
                trackBarGreenFront.Value = mainForm.currentLight.ColorFront.G;
                trackBarBlueFront.Value = mainForm.currentLight.ColorFront.B;

                trackBarBrightnessBack.Value = mainForm.currentLight.BrightnessBack;
                trackBarRedBack.Value = mainForm.currentLight.ColorBack.R;
                trackBarGreenBack.Value = mainForm.currentLight.ColorBack.G;
                trackBarBlueBack.Value = mainForm.currentLight.ColorBack.B;
                // Accent color
                buttonSave.ForeColor = mainForm.currentTheme.AccentColor;
            }
        }
        #endregion

        #region Event Handlers

        private void panelLightSettings_VisibleChanged(object sender, EventArgs e)
        {
            UpdateTabVisuals();
        }
        private void trackBarBrightnessFront_Scroll(object sender, EventArgs e)
        {
            labelBrightnessPercentageFront.Text = string.Format("{0}%", trackBarBrightnessFront.Value);
        }

        private void trackBarBrightnessBack_Scroll(object sender, EventArgs e)
        {
            labelBrightnessPercentageBack.Text = string.Format("{0}%", trackBarBrightnessBack.Value);
        }
        private void ColorFrontChanged(object sender, EventArgs e)
        {
            UpdateFrontPreview();
            labelRedFrontValue.Text = trackBarRedFront.Value.ToString();
            labelGreenFrontValue.Text = trackBarGreenFront.Value.ToString();
            labelBlueFrontValue.Text = trackBarBlueFront.Value.ToString();
        }

        private void ColorBackChanged(object sender, EventArgs e)
        {
            UpdateBackPreview();
            labelRedBackValue.Text = trackBarRedBack.Value.ToString();
            labelGreenBackValue.Text = trackBarGreenBack.Value.ToString();
            labelBlueBackValue.Text = trackBarBlueBack.Value.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }


        #endregion
    }
}
