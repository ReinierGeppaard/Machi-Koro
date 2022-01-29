using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro
{
    class Speler
    {
        public List<Kaart> SpelerKaarten;
      
        public Speler()
        {
            SpelerKaarten = new List<Kaart>();
        }
        public void VoegKaartToe(Kaart kaart)
        {
            SpelerKaarten.Add(kaart);
        }  
        public void HaalKaartWeg(Kaart kaart)
        {
            SpelerKaarten.Remove(kaart);
        }
    }
}
