using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHome
{
    public class Database
    {
        // PRIVATE FIELDS
        MainForm mainForm;
        // PUBLIC PROPERTIES

        // CONSTRUCTORS
        public Database(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }
        // METHODS
        #region Methods handling logging in, creating a new user & updating the user's profile settings

        /// <summary>
        /// This method requests all information of the user with a specific user,
        /// and stores them in the user class on the mainform
        /// </summary>
        /// <param name="username">the content from the login username input field</param>
        /// <param name="password">the content form the login password input field</param>
        /// <returns>true if login was succeful, otherwise false</returns>
        public bool LogIn(string username, string password)
        {
            try
            {
                // Connect to database
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseProftaak12"].ConnectionString))
                {
                    // Open database with name 'db'
                    db.Open();

                    string query = string.Format("select * from [User] where username = '{0}' and password = '{1}'", username, password);

                    using (SqlCommand command = new SqlCommand(query, db))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            mainForm.currentUser.ID = Convert.ToInt32(reader["ID"]);
                            mainForm.currentUser.Username = reader["username"].ToString();
                            mainForm.currentUser.Password = reader["password"].ToString();
                            mainForm.currentUser.NFCID = reader["nfc"].ToString();
                            mainForm.currentUser.Theme = (ThemeColors)Convert.ToInt32(reader["theme"]);
                            return true;
                        }
                        // Message when username and password dont match with any code in the database
                        MessageBox.Show("Username or password is incorrect");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// this method checks if the input username is already present in the database.
        /// If not, the username and password are send to the database as a new user
        /// </summary>
       /// <param name="username">the content of the sign up username input field</param>
        /// <param name="password">the content of the sign up password input field</param>
        public void SignUp(string username, string password)
        {
            // Connect to database
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseProftaak12"].ConnectionString))
            {
                // Open database with name 'db'
                db.Open();
                // Try to get the new username from database to see if it already exists
                string query1 = string.Format("select username from [User] where username = '{0}'",username);
                using (SqlCommand command = new SqlCommand(query1, db))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["username"].ToString() == username)
                        {
                            MessageBox.Show("This username is already taken, please insert another one");
                            return;
                        }
                    }
                }
                // If name is not present in data base, execute following query
                string query2 = string.Format("insert into [User] (username, password) values('{0}','{1}')", username, password);

                using (SqlCommand command = new SqlCommand(query2, db))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// This method updates the user settings,
        /// It sends specific parameters to the user in the database matching the id
        /// </summary>
        /// <param name="theme">the theme colors of the current user, defined by index number, because they are saved in the database as a number</param>
        /// <param name="username">the new username of the user</param>
        /// <param name="password">the new password of the user</param>
        /// <param name="nfc">the nfc id that has been paired</param>
        /// <param name="id">the id of the current user</param>
        public void UpdateUserSettings(int theme, string username, string password, string nfc, int id)
        {
            // Connect to database
            try
            {
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseProftaak12"].ConnectionString))
                {
                    // Open database with name 'db'
                    db.Open();
                    string query = string.Format("update [User] set theme = '{0}', username = '{1}', password = '{2}', nfc = '{3}' where id = '{4}'", theme, username, password, nfc, id);
                    using (SqlCommand command = new SqlCommand(query, db))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Methods handling requesting user settings

        /// <summary>
        /// Load the music of the current user and set the values to the currentMusic instance of the Music class
        /// </summary>
        /// <param name="id">Use the id of the current user to load only their settings</param>
        public void GetMusicSettings(int id)
        {
            try
            {
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseProftaak12"].ConnectionString))
                {
                    // Open database with name 'db'
                    db.Open();
                    string query = string.Format("select * from Musicsettings where id = '{0}'", id);
                    using (SqlCommand command = new SqlCommand(query, db))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            mainForm.currentMusic.OnOff = Convert.ToBoolean(reader["enabled"]);
                            mainForm.currentMusic.Channel = (RadioChannels)Convert.ToInt32(reader["channel"]);
                            return;
                        }
                        SendDefaultMusicSettingsToDataBase(id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GetDoorlockSettings(int id)
        {
            try
            {
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseProftaak12"].ConnectionString))
                {
                    // Open database with name 'db'
                    db.Open();
                    string query = string.Format("select * from LockSettings where id = '{0}'", id);
                    using (SqlCommand command = new SqlCommand(query, db))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            mainForm.currentDoorlock.OpenClosed = Convert.ToBoolean(reader["enabled"]);
                            return;
                        }
                        SendDefaultDoorlockSettingsToDataBase(id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GetLightSettings(int id)
        {
            try
            {
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseProftaak12"].ConnectionString))
                {
                    // Open database with name 'db'
                    db.Open();
                    string query = string.Format("select * from LightSettings where id = '{0}'", id);
                    using (SqlCommand command = new SqlCommand(query, db))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            mainForm.currentLight.OnOffFront = Convert.ToBoolean(reader[""]);
                            mainForm.currentLight.PausePlayFront = Convert.ToBoolean(reader[""]);
                            mainForm.currentLight.OnOffBack = Convert.ToBoolean(reader[""]);
                            mainForm.currentLight.PausePlayBack = Convert.ToBoolean(reader[""]);
                            mainForm.currentLight.BrightnessFront = Convert.ToInt32(reader[""]);
                            mainForm.currentLight.BrightnessBack = Convert.ToInt32(reader[""]);
                            int redFront = Convert.ToInt32(reader[""]);
                            int greenFront = Convert.ToInt32(reader[""]);
                            int blueFront = Convert.ToInt32(reader[""]);
                            int redBack = Convert.ToInt32(reader[""]);
                            int greenBack = Convert.ToInt32(reader[""]);
                            int blueBack = Convert.ToInt32(reader[""]);
                            mainForm.currentLight.ColorFront = Color.FromArgb(redFront, greenFront, blueFront);
                            mainForm.currentLight.ColorBack = Color.FromArgb(redBack, greenBack, blueBack);
                            return;
                        }
                        SendDefaultLightSettingsToDataBase(id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GetCoffeeSettings ()
        {

        }
        #endregion

        #region Methods related to updating the user's settings

        /// <summary>
        /// This method sends the default music settings to the database when a user has no settings present
        /// </summary>
        /// <param name="id">the id of the current user</param>
        public void SendDefaultMusicSettingsToDataBase(int id)
        {
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseProftaak12"].ConnectionString))
            {
                // Open database with name 'db'
                db.Open();
                string query = string.Format("insert into MusicSettings (user_id, channel, enabled) values('{0}','{1}','{2}')", id, 0, 0);
                using (SqlCommand command = new SqlCommand(query, db))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// This method send the new music settings to the datebase
        /// </summary>
        /// <param name="id">the id of the current user</param>
        public void SaveMusicSettings(int channel, bool enabled, int id)
        {
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseProftaak12"].ConnectionString))
            {
                // Open database with name 'db'
                db.Open();
                string query = string.Format("update MusicSettings set channel = '{0}', enabled = '{1}' where id = '{2}'", channel, Convert.ToInt32(enabled), id);
                using (SqlCommand command = new SqlCommand(query, db))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// This method sends the default doorlock settings to the database when a user has no settings present
        /// </summary>
        /// <param name="id">the id of the current user</param>
        public void SendDefaultDoorlockSettingsToDataBase(int id)
        {
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseProftaak12"].ConnectionString))
            {
                // Open database with name 'db'
                db.Open();
                string query = string.Format("insert into LockSettings (user_id, enabled) values('{0}','{1}')", id, 0);
                using (SqlCommand command = new SqlCommand(query, db))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// This method send the new doorlock settings to the datebase
        /// </summary>
        /// <param name="id">the id of the current user</param>
        public void SaveDoorlockSettings(bool enabled, int id)
        {
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseProftaak12"].ConnectionString))
            {
                // Open database with name 'db'
                db.Open();
                string query = string.Format("update LockSettings set enabled = '{0}' where id = '{1}'", Convert.ToInt32(enabled), id);
                using (SqlCommand command = new SqlCommand(query, db))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// This method sends the default light settings to the database when a user has no settings present
        /// </summary>
        /// <param name="id">the id of the current user</param>
        public void SendDefaultLightSettingsToDataBase(int id)
        {

        }
        /// <summary>
        /// This method send the new light settings to the datebase
        /// </summary>
        /// <param name="id">the id of the current user</param>
        public void SaveLightSettings(bool onOffFront, bool pausePlayFront, bool onOffBack, bool pausePlayBack, int brightnessFront, int redFront, int greenFront, int blueFront, int brightnessBack, int redBack, int greenBack, int blueBack)
        {

        }
        #endregion
    }
}
