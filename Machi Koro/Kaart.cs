using System.Collections.Generic;

namespace Machi_Koro
{
    class Kaart
    {
        public List<OranjeKaart> OranjeKaartenB;
        public List<OranjeKaart> OranjeKaarten;
        public string image { get; set; }
        public int kost { get; set; }
        public string effect { get; set; }
        public Kaart()
        {
            OranjeKaarten = new List<OranjeKaart>()
            {
                new OranjeKaart() { image = "../../Resources/TrainStation.png", kost = 4, effect = "" },
                new OranjeKaart() { image = "../../Resources/ShoppingMall.png", kost = 10, effect = "" },
                new OranjeKaart() { image = "../../Resources/AmusementPark.png", kost = 16, effect = "" },
                new OranjeKaart() { image = "../../Resources/RadioTower.png", kost = 22, effect = "" }
            };
            OranjeKaartenB = new List<OranjeKaart>()
            {
                new OranjeKaart() { image = "../../Resources/TrainStationB.png", kost = 4, effect = "" },
                new OranjeKaart() { image = "../../Resources/ShoppingMallB.png", kost = 10, effect = "" },
                new OranjeKaart() { image = "../../Resources/AmusementParkB.png", kost = 16, effect = "" },
                new OranjeKaart() { image = "../../Resources/RadioTowerB.png", kost = 22, effect = "" }
            };
        }
        public OranjeKaart GetAndRemoveOranjeKaart()
        {
            OranjeKaart oranjeKaart = OranjeKaarten[0];
            return oranjeKaart;
        }
        public OranjeKaart GetAndRemoveOranjeKaart2()
        {
            OranjeKaart oranjeKaart = OranjeKaarten[1];
            return oranjeKaart;
        }
        public OranjeKaart GetAndRemoveOranjeKaart3()
        {
            OranjeKaart oranjeKaart = OranjeKaarten[2];
            return oranjeKaart;
        }
        public OranjeKaart GetAndRemoveOranjeKaart4()
        {
            OranjeKaart oranjeKaart = OranjeKaarten[3];
            return oranjeKaart;
        }
        public void RemoveOranjeKaartB()
        {
            OranjeKaartenB.RemoveAt(0);
        }
        public void RemoveOranjeKaart()
        {
            OranjeKaarten.RemoveAt(0);
        }
        public void NieuweOranjeKaartenB()
        {
            OranjeKaartenB.Add(new OranjeKaart() { image = "../../Resources/TrainStationB.png", kost = 4, effect = "" });
            OranjeKaartenB.Add(new OranjeKaart() { image = "../../Resources/ShoppingMallB.png", kost = 10, effect = "" });
            OranjeKaartenB.Add(new OranjeKaart() { image = "../../Resources/AmusementParkB.png", kost = 16, effect = "" });
            OranjeKaartenB.Add(new OranjeKaart() { image = "../../Resources/RadioTowerB.png", kost = 22, effect = "" });
        }
        public OranjeKaart GetAndRemoveOranjeKaartB()
        {
            OranjeKaart oranjekaartb = OranjeKaartenB[0];
            return oranjekaartb;
        }
        public void OranjeKaartKopen(Speler speler)
        {
            speler.VoegKaartToe(OranjeKaarten[0]);
            RemoveOranjeKaart();
        }
    }
}
