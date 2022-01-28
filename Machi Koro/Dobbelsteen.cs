using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro
{
    class Dobbelsteen
    {
        public List<Dobbel> Dobbelstenen;
        public Random rand;
        public Dobbelsteen()
        {
            rand = new Random();
            Dobbelstenen = new List<Dobbel>()
            {
                new Dobbel() { image = "../../Resources/one.png", dobbelnummer = 1},
                new Dobbel() { image = "../../Resources/two.png", dobbelnummer = 2},
                new Dobbel() { image = "../../Resources/three.png", dobbelnummer = 3},
                new Dobbel() { image = "../../Resources/four.png", dobbelnummer = 4},
                new Dobbel() { image = "../../Resources/five.png", dobbelnummer = 5},
                new Dobbel() { image = "../../Resources/six.png", dobbelnummer = 6},

            };
        }
        public Dobbel RandomNummer()
        {
            return Dobbelstenen[rand.Next(0, 5)];
           
        }
    }
}
