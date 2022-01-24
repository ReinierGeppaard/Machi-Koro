using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro
{
    class BlauweKaart
    {
        public List<BlauweKaart> BlauweKaarten;
        public string image { get; set; }
        public int kost { get; set; }
        public int nummer { get; set; }
        public string icoon { get; set; }
        public string effect { get; set; }
        public BlauweKaart()
        {
            BlauweKaarten = new List<BlauweKaart>()
            {
            new BlauweKaart() { image = "../../Resources/WheatField.png", kost = 1, nummer = 1, icoon = "", effect = "" },
            new BlauweKaart() { image = "../../Resources/Ranch.png", kost = 1, nummer = 2, icoon = "", effect = "" },
            new BlauweKaart() { image = "../../Resources/Mine.png", kost = 6, nummer = 9, icoon = "", effect = "" },
            new BlauweKaart() { image = "../../Resources/Forest.png", kost = 3, nummer = 5, icoon = "", effect = "" },
            new BlauweKaart() { image = "../../Resources/AppleOrchard.png", kost = 3, nummer = 10, icoon = "", effect = "" }
            };
        }
    }
}
