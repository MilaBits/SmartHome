using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Theme
    {
        // PRIVATE FIELDS
        private Color headerColor;
        private Color topBarColor;
        private Color accentColor;
        // PUBLIC PROPERTIES
        public Color HeaderColor
        {
            get { return this.headerColor; }
            set { this.headerColor = value; }
        }
        public Color TopBarColor
        {
            get { return this.topBarColor; }
            set { this.topBarColor = value; }
        }
        public Color AccentColor
        {
            get { return this.accentColor; }
            set { this.accentColor = value; }
        }
        // CONSTRUCTORS
        public Theme(Color head, Color top, Color accent)
        {
            this.headerColor = head;
            this.topBarColor = top;
            this.accentColor = accent;
        }
        // METHODS
        
    }
}
