using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Light
    {
        // PRIVATE FIELDS
        private bool onOffFront;
        private bool pausePlayFront;
        private bool onOffBack;
        private bool pausePlayBack;
        private int brightnessFront;
        private int brightnessBack;
        private Color colorFront;
        private Color colorBack;
        // PUBLIC PROPERTIES
        public bool OnOffFront
        {
            get { return this.onOffFront; }
            set { this.onOffFront = value; }
        }
        public bool PausePlayFront
        {
            get { return this.pausePlayFront; }
            set { this.pausePlayFront = value; }
        }
        public bool OnOffBack
        {
            get { return this.onOffBack; }
            set { this.onOffBack = value; }
        }
        public bool PausePlayBack
        {
            get { return this.pausePlayBack; }
            set { this.pausePlayBack = value; }
        }
        public int BrightnessFront
        {
            get { return this.brightnessFront; }
            set { this.brightnessFront = value; }
        }
        public int BrightnessBack
        {
            get { return this.brightnessBack; }
            set { this.brightnessBack = value; }
        }
        public Color ColorFront
        {
            get { return this.colorFront; }
            set { this.colorFront = value; }
        }
        public Color ColorBack
        {
            get { return this.colorBack; }
            set { this.colorBack = value; }
        }
        // CONSTRUCTORS
        public Light()
        {

        }
        // METHODS

    }
}
