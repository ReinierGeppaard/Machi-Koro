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
        public List<Dobbel> Gedobbeld;

        public Dobbelsteen()
        {
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
        public void RandomNummer()
        {
            Random rand = new Random();
            Dobbel temp;
            {
                for (int draaien = 0; draaien < 50; draaien++)
                {
                    for (int i = 0; i < Dobbelstenen.Count; i++)
                    {
                        int Omdraaien = rand.Next(2);
                        temp = Dobbelstenen[i];
                        Dobbelstenen[i] = Dobbelstenen[Omdraaien];
                        Dobbelstenen[Omdraaien] = temp;
                    }
                }
            }
        }
        public void Dobbelen()
        {
            Gedobbeld = new List<Dobbel>();
            for (int a = 0; a < 1; a++)
            {
                Gedobbeld.Add(Dobbelstenen[0]);
            }
        }
        public Dobbel GetAndRemoveDobbel()
        {
            Dobbel dobbel = Dobbelstenen[0];
            return dobbel;
        }
    }
}
