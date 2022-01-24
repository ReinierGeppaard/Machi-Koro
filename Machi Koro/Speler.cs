using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro
{
    class Speler
    {
        public List<OranjeKaart> OranjeSpelerKaarten;
      
        public Speler()
        {
            OranjeSpelerKaarten = new List<OranjeKaart>();
        }
        public void VoegKaartToe(OranjeKaart oranjekaart)
        {
            OranjeSpelerKaarten.Add(oranjekaart);
        }  
    }
}
