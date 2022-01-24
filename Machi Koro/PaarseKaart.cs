using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro
{
    class PaarseKaart
    {
        public List<PaarseKaart> PaarseKaarten;
        public string image { get; set; }
        public int kost { get; set; }
        public int nummer { get; set; }
        public string icoon { get; set; }
        public string effect { get; set; }
        public PaarseKaart()
        {
            PaarseKaarten = new List<PaarseKaart>()
            {
                new PaarseKaart() { image = "../../Resources/BusinessCenter.png", kost = 8, nummer = 6, icoon = "", effect = "" },
                new PaarseKaart() { image = "../../Resources/TvStation.png", kost = 7, nummer = 6, icoon = "", effect = "" },
                new PaarseKaart() { image = "../../Resources/Stadium.png", kost = 6, nummer = 6, icoon = "", effect = "" }
            };
        }
    }
}
