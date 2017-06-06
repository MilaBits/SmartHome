using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class LogInForm : Form
    {
        // PRIVATE FIELDS
        private bool succes = false;
        Database db;
        // PUBLIC PROPERTIES
        public bool Succes
        {
            get { return this.succes; }
            set { this.succes = value; }
        }
        // CONSTRUCTORS
        public LogInForm(MainForm mainForm)
        {
            InitializeComponent();
            db = new Database(mainForm);
        }
        // METHODS

        #region All methods related to logging in
        private void LogIn()
        {
            this.succes = db.LogIn(textBoxLogInUsername.Text, textBoxLogInPassword.Text);
            if (this.succes)
            {
                // Clear login input fields
                textBoxLogInUsername.Text = string.Empty;
                textBoxLogInPassword.Text = string.Empty;
                this.Close();
            }
        }
        #endregion

        #region All methods related to creating a new user

        /// <summary>
        /// This method checks if the input field for the username is empty,
        /// then checks if the username is whitespace
        /// </summary>
        /// <param name="username">the content form the sign up username input field</param>
        /// <returns>the method returns true if the username is valid, otherwise false</returns>
        private bool SetUsername(string username)
        {
            if (!string.IsNullOrEmpty(username))
            {
                if (!string.IsNullOrWhiteSpace(username))
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
                MessageBox.Show("You must insert a username");
                return false;
            }
        }
        /// <summary>
        /// This method checks if the input password is empty,
        /// then checks if the password is whitespace,
        /// then checks if the password matches the one in the password again textbox
        /// </summary>
        /// <param name="password">the content from the sign up password input field</param>
        /// <param name="passwordAgain">the content from the sign up password again input field</param>
        /// <returns>the method returns true if the password is valid, otherwise false</returns>
        private bool SetPassword(string password, string passwordAgain)
        {
            if (!string.IsNullOrEmpty(password))
            {
                if (!string.IsNullOrWhiteSpace(password))
                {
                    if (password == passwordAgain)
                    {
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
                MessageBox.Show("You must insert a password");
                return false;
            }
        }
        /// <summary>
        /// This method handles the creating of a new user.
        /// It checks if the username is valid, then if the password is valid.
        /// And only when both are, the database content will be updated
        /// </summary>
        /// <param name="username">the content from the sign up username input field</param>
        /// <param name="password">the content from the sign up password input field</param>
        /// <param name="passwordAgain">the content from the sign up password again input field</param>
        private void SignUp(string username, string password, string passwordAgain)
        {
            bool usernameIsValid = SetUsername(username);
            bool passwordIsValid = SetPassword(password, passwordAgain);
            try
            {
                if (usernameIsValid && passwordIsValid)
                {
                    // Handle database side of signing up
                    db.SignUp(username, password);
                    HideSignUp();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Updating visuals
        private void ShowSignUp()
        {
            // Show all sign up input fields
            this.Height = 360;
            buttonNewUser.Visible = false;
            labelSignUpUsername.Visible = true;
            labelSignUpPassword.Visible = true;
            labelSignUpPasswordAgain.Visible = true;
            textBoxSignUpUsername.Visible = true;
            textBoxSignUpUsername.TabStop = true;
            textBoxSignUpPassword.Visible = true;
            textBoxSignUpPassword.TabStop = true;
            textBoxSignUpPasswordAgain.Visible = true;
            textBoxSignUpPasswordAgain.TabStop = true;
            buttonSignUp.Visible = true;
            buttonSignUp.TabStop = true;
        }

        private void HideSignUp()
        {
            textBoxSignUpUsername.Text = string.Empty;
            textBoxSignUpPassword.Text = string.Empty;
            textBoxSignUpPasswordAgain.Text = string.Empty;
            this.Height = 180;
            buttonNewUser.Visible = true;
            labelSignUpUsername.Visible = false;
            labelSignUpPassword.Visible = false;
            labelSignUpPasswordAgain.Visible = false;
            textBoxSignUpUsername.Visible = false;
            textBoxSignUpUsername.TabStop = false;
            textBoxSignUpPassword.Visible = false;
            textBoxSignUpPassword.TabStop = false;
            textBoxSignUpPasswordAgain.Visible = false;
            textBoxSignUpPasswordAgain.TabStop = false;
            buttonSignUp.Visible = false;
            buttonSignUp.TabStop = false;
        }
        #endregion

        #region Event Handlers
        private void LogInForm_Load(object sender, EventArgs e)
        {
            // Make form height 180 px, because form is larger in editor to be able to see the sign up groupbox
            this.Height = 180;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            ShowSignUp();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUp(textBoxSignUpUsername.Text, textBoxSignUpPassword.Text, textBoxSignUpPasswordAgain.Text);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        /// <summary>
        /// This code snippet makes sure that the log in form can be dragged by the custom top bar.
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void flowLayoutPanelTopBarLogInForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
