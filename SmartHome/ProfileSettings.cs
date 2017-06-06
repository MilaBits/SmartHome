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

namespace SmartHome
{
    public partial class ProfileSettings : UserControl
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
        public ProfileSettings()
        {
            InitializeComponent();
        }

        // METHODS

        #region NFC reader
        /// <summary>
        /// The method opens the serial port and saves everyting what it reads to the character #
        /// Then it overwrites with everyting after the # to the % character.
        /// </summary>
        /// <returns>everyting between the # and % characters are returned</returns>
        private string ConnectNFC()
        {
            serialPort2.Open();
            string read = serialPort2.ReadTo("#");
            read = serialPort2.ReadTo("%");
            serialPort2.Close();
            return read;
        }
        #endregion

        #region All methods related to changing the currrent user's settings

        /// <summary>
        /// This method sets the theme of the current user to the theme matching the selected radiobutton
        /// </summary>
        private void SetTheme()
        {
            if (radioButtonTeal.Checked)
            {
                mainForm.currentUser.Theme = ThemeColors.Teal;
            }
            else if (radioButtonRed.Checked)
            {
                mainForm.currentUser.Theme = ThemeColors.Red;
            }
            else if (radioButtonBlueGrey.Checked)
            {
                mainForm.currentUser.Theme = ThemeColors.BlueGrey;
            }
            else if (radioButtonPurple.Checked)
            {
                mainForm.currentUser.Theme = ThemeColors.Purple;
            }
        }

        /// <summary>
        /// /// This method checks if nwe username is empty,
        /// then checks if the username is whitespace
        /// </summary>
        /// <returns>true if the username is valid or no new username is being set, otherwise false</returns>
        private bool SetUsername()
        {
            if (!string.IsNullOrWhiteSpace(textBoxNewUsername.Text))
            {
                mainForm.currentUser.Username = textBoxNewUsername.Text;
            }
            if (!string.IsNullOrEmpty(textBoxNewUsername.Text))
            {
                if (!string.IsNullOrWhiteSpace(textBoxNewUsername.Text))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("You cannot use whitespace as username");
                    return false;
                }
            }
            else
            {
                return true; // No new username is being set, which is a valid option. Database query still has to run, so true is returned
            }
        }
        /// <summary>
        /// This method checks if the new password is empty,
        /// then checks if the password is whitespace,
        /// then checks if the password matches the one in the password again textbox
        /// </summary>
        /// <returns>returns true if valid or no new password is being set, otherwise false</returns>
        private bool SetPassword()
        {
            if (!string.IsNullOrEmpty(textBoxNewPassword.Text))
            {
                if (!string.IsNullOrWhiteSpace(textBoxNewPassword.Text))
                {
                    if (textBoxNewPassword.Text == textBoxNewPasswordAgain.Text)
                    {
                        mainForm.currentUser.Password = textBoxNewPassword.Text;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("The passwords do not match");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("You cannot use whitespace as password");
                    return false;
                }
            }
            else
            {
                return true; // No new password is being set, which is a valid option. Database query still has to run, so true is returned
            }
        }
        /// <summary>
        /// This method saves the settings to the database
        /// then it updates the following: 
        /// the profile settings tab so that the username and password input fields are empty,
        /// the content box in the top right, to match a new nfc id and username,
        /// the theme colors to match the new theme
        /// </summary>
        private void Save()
        {
            // Set new theme
            SetTheme();
            // Set new username
           bool newUsernameIsValid = SetUsername();
            // Set new password
            bool newPasswordIsValid = SetPassword();
            if (newUsernameIsValid && newPasswordIsValid)
            {
                db.UpdateUserSettings(
                    (int)mainForm.currentUser.Theme,
                    mainForm.currentUser.Username,
                    mainForm.currentUser.Password,
                    mainForm.currentUser.NFCID,
                    mainForm.currentUser.ID);
                // Update screen
                textBoxNewUsername.Text = string.Empty;
                textBoxNewPassword.Text = string.Empty;
                textBoxNewPasswordAgain.Text = string.Empty;
                mainForm.UpdateTheme(mainForm.currentUser.Theme);
                UpdateTabVisuals();  //Update the current tab, so the selected radiobutton becomes the new accent color
                mainForm.UpdateContentBox(mainForm.currentUser.Username, mainForm.currentUser.NFCID);
            }
        }
        #endregion

        #region Updating visuals
        /// <summary>
        /// The method checks and colors the correct radiobutton that matches the current user's theme settings,
        /// and it colors the buttons to the accent color
        /// </summary>
        private void UpdateTabVisuals()
        {
            // Set the correct radio button dependent on the user's theme
            if (panelProfileSettings.Visible && this.mainForm != null)
            {
                switch (mainForm.currentUser.Theme)
                {
                    case ThemeColors.Teal:
                        radioButtonTeal.Checked = true;
                        radioButtonTeal.ForeColor = mainForm.currentTheme.AccentColor;
                        break;
                    case ThemeColors.Red:
                        radioButtonRed.Checked = true;
                        radioButtonRed.ForeColor = mainForm.currentTheme.AccentColor;
                        break;
                    case ThemeColors.BlueGrey:
                        radioButtonBlueGrey.Checked = true;
                        radioButtonBlueGrey.ForeColor = mainForm.currentTheme.AccentColor;
                        break;
                    case ThemeColors.Purple:
                        radioButtonPurple.Checked = true;
                        radioButtonPurple.ForeColor = mainForm.currentTheme.AccentColor;
                        break;
                    default:
                        radioButtonTeal.Checked = true;
                        break;
                }
                if (!string.IsNullOrWhiteSpace(mainForm.currentUser.NFCID))
                {
                    buttonPairNFC.Text = "Disconnect NFC Device";
                }
                // Accent color
                buttonSave.ForeColor = mainForm.currentTheme.AccentColor;
                buttonPairNFC.ForeColor = mainForm.currentTheme.AccentColor;
            }
        }
        #endregion

        #region Event Handlers

        private void ProfileSettings_VisibleChanged(object sender, EventArgs e)
        {
            UpdateTabVisuals();
        }

        private void ThemeChanged(object sender, EventArgs e)
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
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void buttonPairNFC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mainForm.currentUser.NFCID))
            {
                mainForm.currentUser.NFCID = ConnectNFC();
                buttonPairNFC.Text = "Disconnect NFC Device";
                MessageBox.Show("NFC Device Connected, don't forget to save");
            }
            else
            {
                mainForm.currentUser.NFCID = string.Empty;
                buttonPairNFC.Text = "Connect NFC Device";
                MessageBox.Show("NFC Device Disconnected, don't forget to save");
            }
        }
        #endregion
    }
}
