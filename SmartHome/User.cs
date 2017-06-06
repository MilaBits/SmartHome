using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class User
    {
        // PRIVATE FIELDS
        private int id;
        private string username;
        private string password;
        private string nfcID;
        private ThemeColors theme;
        // PUBLIC PROPERTIES
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public string NFCID
        {
            get { return this.nfcID; }
            set { this.nfcID = value; }
        }
        public ThemeColors Theme
        {
            get { return this.theme; }
            set { this.theme = value; }
        }
        // CONSTRUCTORS
        public User()
        {

        }
        // METHODS
    }
}
