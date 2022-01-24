using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Machi_Koro
{
    class RodeKaart
    {
        public List<RodeKaart> RodeKaarten;
        public string image { get; set; }
        public int kost { get; set; }
        public int nummer { get; set; }
        public string icoon { get; set; }
        public string effect { get; set; }
        public RodeKaart()
        {
            RodeKaarten = new List<RodeKaart>()
            {
                new RodeKaart() { image = "../../Resources/Cafe.png", kost = 2, nummer = 3, icoon = "", effect = "" },
                new RodeKaart() { image = "../../Resources/FamilyRestaurant.png", kost = 3, nummer = 9, icoon = "", effect = "" }
            };
        }
    }
}
