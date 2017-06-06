using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Music
    {
        // PRIVATE FIELDS
        private bool onOff;
        private RadioChannels channel;
        private string link;

        // PUBLIC PROPERTIES
        public bool OnOff
        {
            get { return this.onOff; }
            set { this.onOff = value;  }
        }
        public RadioChannels Channel
        {
            get { return this.channel; }
            set { this.channel = value; }
        }
        public string Link
        {
            get { return GetLink(channel); }
        }
        // CONSTRUCTORS
        public Music()
        {
            
        }
        // METHODS

        /// <summary>
        /// This method returns a string that matches a specific radio channel
        /// </summary>
        /// <param name="channel">the radio channel that matches the radio button</param>
        /// <returns>a link that opens a digital stream of the matching radio channel</returns>
        private string GetLink(RadioChannels channel)
        {
            switch (channel)
            {
                case RadioChannels.radio3fm:
                    return "http://icecast.omroep.nl/3fm-bb-mp3";
                case RadioChannels.radio538:
                    return "http://vip-icecast.538.lw.triple-it.nl/RADIO538_MP3";
                case RadioChannels.qMusic:
                    return "http://icecast-qmusic.cdp.triple-it.nl/Qmusic_nl_live_96.mp3";
                case RadioChannels.arrowClassicRock:
                    return "http://91.221.151.155:80/;?.mp3";
                case RadioChannels.slam:
                    return "http://stream.slam.nl/slam";
                case RadioChannels.nl100:
                    return "http://stream.100p.nl/100pctnl.mp3";
                default:
                    return "http://icecast.omroep.nl/3fm-bb-mp3";
            }
        }
    }
}
