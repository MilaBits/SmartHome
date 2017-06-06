using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace SmartHome
{
    public partial class MusicSettings : UserControl
    {
        // PRIVATE FIELDS
        private MainForm mainForm;
        private Database db;
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
        public MusicSettings()
        {
            InitializeComponent();
        }
        // METHODS

        #region All methods related to changing the music settings

        /// <summary>
        /// This method changes the music settings according to the checkbox
        /// </summary>
        private void SetOnOff()
        {
            if (checkBoxRadioOn.Checked)
            {
                mainForm.currentMusic.OnOff = true;
            }
            else
            {
                mainForm.currentMusic.OnOff = false;
            }
        }
        /// <summary>
        /// This method changes the radio channel of the current user in the music settings
        /// </summary>
        private void SetChannel()
        {
            if (radioButtonChannel1.Checked)
            {
                mainForm.currentMusic.Channel = RadioChannels.radio3fm;
            }
            else if (radioButtonChannel2.Checked)
            {
                mainForm.currentMusic.Channel = RadioChannels.radio538;
            }
            else if (radioButtonChannel3.Checked)
            {
                mainForm.currentMusic.Channel = RadioChannels.qMusic;
            }
            else if (radioButtonChannel4.Checked)
            {
                mainForm.currentMusic.Channel = RadioChannels.arrowClassicRock;
            }
            else if (radioButtonChannel5.Checked)
            {
                mainForm.currentMusic.Channel = RadioChannels.slam;
            }
            else if (radioButtonChannel6.Checked)
            {
                mainForm.currentMusic.Channel = RadioChannels.nl100;
            }
        }
        /// <summary>
        /// This methods saves the settings to the database
        /// </summary>
        private void Save()
        {
            // Set the enabled bool
            SetOnOff();
            // Set the new channel
            SetChannel();
            db.SaveMusicSettings((int)mainForm.currentMusic.Channel, mainForm.currentMusic.OnOff, mainForm.currentUser.ID);
        }
        #endregion

        #region Updating visuals
        /// <summary>
        /// The method checks the checkbox, if needed, and it colors the buttons to the accent color
        /// </summary>
        private void UpdateTabVisuals()
        {
            // Set the correct radio button dependent on the user's theme
            if (panelMusicSettings.Visible && this.mainForm != null)
            {
                if (mainForm.currentMusic.OnOff)
                {
                    checkBoxRadioOn.Checked = true;
                }
                else
                {
                    checkBoxRadioOn.Checked = false;
                }
                switch (mainForm.currentMusic.Channel)
                {
                    case RadioChannels.radio3fm:
                        radioButtonChannel1.Checked = true;
                        radioButtonChannel1.ForeColor = mainForm.currentTheme.AccentColor;
                        break;
                    case RadioChannels.radio538:
                        radioButtonChannel2.Checked = true;
                        radioButtonChannel2.ForeColor = mainForm.currentTheme.AccentColor;
                        break;
                    case RadioChannels.qMusic:
                        radioButtonChannel3.Checked = true;
                        radioButtonChannel3.ForeColor = mainForm.currentTheme.AccentColor;
                        break;
                    case RadioChannels.arrowClassicRock:
                        radioButtonChannel4.Checked = true;
                        radioButtonChannel4.ForeColor = mainForm.currentTheme.AccentColor;
                        break;
                    case RadioChannels.slam:
                        radioButtonChannel5.Checked = true;
                        radioButtonChannel5.ForeColor = mainForm.currentTheme.AccentColor;
                        break;
                    case RadioChannels.nl100:
                        radioButtonChannel6.Checked = true;
                        radioButtonChannel6.ForeColor = mainForm.currentTheme.AccentColor;
                        break;
                    default:
                        radioButtonChannel1.Checked = true;
                        break;
                }
                // Accent color
                buttonPlay.ForeColor = mainForm.currentTheme.AccentColor;
                buttonSave.ForeColor = mainForm.currentTheme.AccentColor;
            }
        }
        #endregion

        #region Event Handlers
        private void MusicSettings_VisibleChanged(object sender, EventArgs e)
        {
            UpdateTabVisuals();
        }

        private void RadioChannelChanged(object sender, EventArgs e)
        {
            foreach (Control item in ((Control)sender).Parent.Controls)
            {
                if (item is RadioButton)
                {
                    item.ForeColor = Color.FromArgb(33, 33, 33);
                }
            }
            ((RadioButton)sender).ForeColor = mainForm.currentTheme.AccentColor;
            
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            SetChannel();
            Process.Start(mainForm.currentMusic.Link);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        #endregion
    }
}
