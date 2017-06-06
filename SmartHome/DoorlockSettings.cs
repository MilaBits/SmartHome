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
    public partial class DoorlockSettings : UserControl
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
        public DoorlockSettings()
        {
            InitializeComponent();
        }

        // METHODS

        #region Methods related to changing the doorlock settings
        /// <summary>
        /// This methods sets the open/closed bool according to the checked radio button
        /// </summary>
        private void SetOpenClosed()
        {
            if (radioButtonUnlocked.Checked)
            {
                mainForm.currentDoorlock.OpenClosed = true;
            }
            else if (radioButtonLocked.Checked)
            {
                mainForm.currentDoorlock.OpenClosed = false;
            }
        }
        /// <summary>
        /// This method saves the settings to the database
        /// </summary>
        private void Save()
        {
            // Set the enabled bool
            SetOpenClosed();
            db.SaveDoorlockSettings(mainForm.currentDoorlock.OpenClosed, mainForm.currentUser.ID);
        }
        #endregion

        #region Updating visuals
        /// <summary>
        /// The method checks the the correct radio button and it colors the button to the accent color
        /// </summary>
        private void UpdateTabVisuals()
        {
            if (panelDoorlockSettings.Visible && this.mainForm != null)
            {
                if (mainForm.currentDoorlock.OpenClosed)
                {
                    radioButtonUnlocked.Checked = true;
                    radioButtonUnlocked.ForeColor = mainForm.currentTheme.AccentColor;
                }
                else if (!mainForm.currentDoorlock.OpenClosed)
                {
                    radioButtonLocked.Checked = true;
                    radioButtonLocked.ForeColor = mainForm.currentTheme.AccentColor;
                }
                // Accent color
                buttonSave.ForeColor = mainForm.currentTheme.AccentColor;
            }
        }
        #endregion

        #region Event Handlers
        private void DoorlockSettings_VisibleChanged(object sender, EventArgs e)
        {
            UpdateTabVisuals();
        }

        private void LockStateChanged(object sender, EventArgs e)
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
        #endregion
    }
}
