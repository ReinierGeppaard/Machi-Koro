using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro
{
    class GroeneKaart
    {
        public List<GroeneKaart> GroeneKaarten;
        public string image { get; set; }
        public int kost { get; set; }
        public int nummer { get; set; }
        public string icoon { get; set; }
        public string effect { get; set; }
        public GroeneKaart()
        {
            GroeneKaarten = new List<GroeneKaart>()
            {
                new GroeneKaart() { image = "../../Resources/Bakery.png", kost = 1, nummer = 3, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/ConvenienceStore.png", kost = 2, nummer = 4, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/CheeseFactory.png", kost = 5, nummer = 7, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/FurnitureFactory.png", kost = 3, nummer = 8, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/FruitAndVegetableMarket.png", kost = 2, nummer = 11, icoon = "", effect = "" }
            };
        }
    }
}
