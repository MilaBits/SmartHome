using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHome
{
    public enum TabName
    {
        ProfileSettings,
        MusicSettings,
        DoorlockSettings,
        LightSettings,
        CoffeeSettings
    }

    public enum ThemeColors
    {
        Teal,
        Red,
        BlueGrey,
        Purple
    }
    
    public enum RadioChannels
    {
        radio3fm,
        radio538,
        qMusic,
        arrowClassicRock,
        slam,
        nl100
    }
    public partial class MainForm : Form
    {
        // PRIVATE FIELDS
        bool buttonLogInEnabled = true;
        bool buttonLogOutEnabled = false;
        LogInForm logIn;
        Database db;

        // PUBLIC FIELDS
        public User currentUser;                                // Contains all the data of the user that is currently logged in
        public Music currentMusic = new Music();                // Contains all the music settings for the current user
        public Doorlock currentDoorlock = new Doorlock();       // Contains all the doorlock settings for the current user
        public Light currentLight = new Light();                // Contains all the light settings for the current user
        //public Coffee currentCoffee = new Coffee();           // Contains all the coffee settings for the current user
        public Theme currentTheme = new Theme(Color.FromArgb(0, 150, 136), Color.FromArgb(0, 121, 107), Color.FromArgb(0, 188, 211));
        List<UserControl> settingsTabs = new List<UserControl>();
        public MainForm()
        {
            InitializeComponent();
            InitializeClasses();
        }

        // METHODS
        #region Methods to initialize classes
        /// <summary>
        /// This method makes one instantion of the Database class so it can be send to all User controls,
        /// and also sends this Form so the methods and fields can be accessed from every user control
        /// </summary>
        private void InitializeClasses()
        {
            db = new Database(this);
            logIn = new LogInForm(this);

            profileSettings.MainForm = this;
            profileSettings.Db = this.db;

            musicSettings.MainForm = this;
            musicSettings.Db = this.db;

            doorlockSettings.MainForm = this;
            doorlockSettings.Db = this.db;

            lightSettings.MainForm = this;
            lightSettings.Db = this.db;

            //coffeeSettings.MainForm = this;
            //coffeeSettings.Db = this.db;

            settingsTabs.Add(profileSettings);
            settingsTabs.Add(musicSettings);
            settingsTabs.Add(doorlockSettings);
            settingsTabs.Add(lightSettings);
            //settingsTabs.Add(coffeeSettings);
        }
        #endregion

        #region Methods related to logging in and out

        /// <summary>
        /// This method opens the log in form loads the user's settitngs if the login was succeful
        /// </summary>
        private void LogIn()
        {
            currentUser = new User();
            logIn.ShowDialog();
            if (logIn.Succes)
            {
                db.GetMusicSettings(currentUser.ID);
                db.GetDoorlockSettings(currentUser.ID);
                db.GetLightSettings(currentUser.ID);
                //db.GetCoffeeSettings(currentUser.ID);
                // Update visuals for logging in
                UpdateTheme(currentUser.Theme);
                UpdateContentBox(currentUser.Username, currentUser.NFCID);
                // Disable login button and enable logout button
                buttonLogIn.ForeColor = Color.FromArgb(189, 189, 189);
                buttonLogInEnabled = false;
                buttonLogIn.TabStop = false;
                buttonLogOut.ForeColor = currentTheme.AccentColor;
                buttonLogOutEnabled = true;
                buttonLogOut.TabStop = true;
            }
        }
        /// <summary>
        ///  /// This method logs out. which means updating the visuals (does not wipe the data of the last logged in user)
        /// </summary>
        private void LogOut()
        {
            currentUser = null;
            logIn.Succes = false;
            // Update visuals for logging out
            UpdateTheme(ThemeColors.Teal);
            UpdateContentBox("No user logged in", "");
            // Disable logout button and enable login button
            buttonLogIn.ForeColor = currentTheme.AccentColor;
            buttonLogInEnabled = true;
            buttonLogIn.TabStop = true;
            buttonLogOut.ForeColor = Color.FromArgb(189, 189, 189);
            buttonLogOutEnabled = false;
            buttonLogOut.TabStop = false;
        }
        #endregion

        #region All methods related to updating the look of the form
        /// <summary>
        /// - The UpdateTheme method sets the header and accent color of the form
        /// - The UpdateContentBox method updates the values in the content box in the top right. (e.g. when the username is changed)
        /// - The OpenTab method opens the tab related to the navigation button that is clicked. it uses the ClosedTab method to close all other tabs
        /// </summary>

        public void UpdateTheme(ThemeColors theme)
        {
            switch (theme)
            {
                case ThemeColors.Teal:
                    currentTheme.HeaderColor = Color.FromArgb(0, 150, 136);
                    currentTheme.TopBarColor = Color.FromArgb(0, 121, 107);
                    currentTheme.AccentColor = Color.FromArgb(0, 188, 211);
                    break;
                case ThemeColors.Red:
                    currentTheme.HeaderColor = Color.FromArgb(243, 67, 54);
                    currentTheme.TopBarColor = Color.FromArgb(210, 47, 47);
                    currentTheme.AccentColor = Color.FromArgb(254, 152, 0);
                    break;
                case ThemeColors.BlueGrey:
                    currentTheme.HeaderColor = Color.FromArgb(96, 125, 139);
                    currentTheme.TopBarColor = Color.FromArgb(69, 90, 100);
                    currentTheme.AccentColor = Color.FromArgb(254, 87, 34);
                    break;
                case ThemeColors.Purple:
                    currentTheme.HeaderColor = Color.FromArgb(156, 39, 176);
                    currentTheme.TopBarColor = Color.FromArgb(123, 31, 162);
                    currentTheme.AccentColor = Color.FromArgb(254, 64, 129);
                    break;
                default:
                    MessageBox.Show("This User has an invalid theme index");
                    break;
            }
            panelHeader.BackColor = currentTheme.HeaderColor;
            flowLayoutPanelTopBar.BackColor = currentTheme.TopBarColor;
            flowLayoutPanelNavBar.BackColor = currentTheme.HeaderColor;
            if (buttonLogInEnabled)
            {
                buttonLogIn.ForeColor = currentTheme.AccentColor;
            }
            if (buttonLogOutEnabled)
            {
                buttonLogOut.ForeColor = currentTheme.AccentColor;
            }
        }

        public void UpdateContentBox(string username, string nfcID)
        {
            labelLoggedInAs.Text = username;
            if (string.IsNullOrWhiteSpace(nfcID))
            {
                labelNFC.Text = "NFC ID - <no NFC device paired>";
            }
            else
            {
                labelNFC.Text = "NFC ID - " + nfcID;
            }
        }

        private void OpenTab(TabName tabName)
        {
            CloseTabs();
            if (logIn.Succes)
            {
                settingsTabs[(int)tabName].Visible = true;
                
            }
        }

        private void CloseTabs()
        {
            foreach (UserControl tab in settingsTabs)
            {
                tab.Visible = false;
            }
        }
        #endregion

        #region Event Handlers

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (buttonLogInEnabled)
            {
                LogIn();
                OpenTab(TabName.ProfileSettings);
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            if (buttonLogOutEnabled)
            {
                LogOut();
                CloseTabs();
            }
        }

        private void buttonProfileSettings_Click(object sender, EventArgs e)
        {
            OpenTab(TabName.ProfileSettings);
        }

        private void buttonMusicSettings_Click(object sender, EventArgs e)
        {
            OpenTab(TabName.MusicSettings);
        }

        private void buttonLockSettings_Click(object sender, EventArgs e)
        {
            OpenTab(TabName.DoorlockSettings);
        }

        private void buttonLightSettings_Click(object sender, EventArgs e)
        {
            OpenTab(TabName.LightSettings);
        }

        private void buttonCoffeeSettings_Click(object sender, EventArgs e)
        {
            OpenTab(TabName.CoffeeSettings);
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}