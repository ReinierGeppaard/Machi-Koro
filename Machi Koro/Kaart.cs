using System.Collections.Generic;

namespace Machi_Koro
{
    class Kaart
    {
        public List<OranjeKaart> OranjeKaartenB;
        public List<OranjeKaart> OranjeKaarten;
        public List<BlauweKaart> WheatField;
        public List<BlauweKaart> Ranch;
        public List<BlauweKaart> Mine;
        public List<BlauweKaart> Forest;
        public List<BlauweKaart> AppleOrchard;
        public List<GroeneKaart> Bakery;
        public List<GroeneKaart> ConvenienceStore;
        public List<GroeneKaart> CheeseFactory;
        public List<GroeneKaart> FurnitureFactory;
        public List<GroeneKaart> FruitAndVegetableMarket;
        public List<RodeKaart> Cafe;
        public List<RodeKaart> FamilyRestaurant;
        public List<PaarseKaart> BusinessCenter;
        public List<PaarseKaart> TvStation;
        public List<PaarseKaart> Stadium;

        public string image { get; set; }
        public int kost { get; set; }
        public string effect { get; set; }
        public Kaart()

            //Oranje kaarten lijsten
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
            //Blauwe kaarten lijsten
            WheatField = new List<BlauweKaart>()
            {
                new BlauweKaart() { image = "../../Resources/WheatField.png", kost = 1, nummer = 1, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/WheatField.png", kost = 1, nummer = 1, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/WheatField.png", kost = 1, nummer = 1, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/WheatField.png", kost = 1, nummer = 1, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/WheatField.png", kost = 1, nummer = 1, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/WheatField.png", kost = 1, nummer = 1, icoon = "", effect = "" }
            };
            Ranch = new List<BlauweKaart>()
            {
                new BlauweKaart() { image = "../../Resources/Ranch.png", kost = 1, nummer = 2, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/Ranch.png", kost = 1, nummer = 2, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/Ranch.png", kost = 1, nummer = 2, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/Ranch.png", kost = 1, nummer = 2, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/Ranch.png", kost = 1, nummer = 2, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/Ranch.png", kost = 1, nummer = 2, icoon = "", effect = "" }
            };
            Mine = new List<BlauweKaart>()
            {
                new BlauweKaart() { image = "../../Resources/Mine.png", kost = 6, nummer = 9, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/Mine.png", kost = 6, nummer = 9, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/Mine.png", kost = 6, nummer = 9, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/Mine.png", kost = 6, nummer = 9, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/Mine.png", kost = 6, nummer = 9, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/Mine.png", kost = 6, nummer = 9, icoon = "", effect = "" }
            };
            Forest = new List<BlauweKaart>()
            {
                new BlauweKaart() { image = "../../Resources/Forest.png", kost = 3, nummer = 5, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/Forest.png", kost = 3, nummer = 5, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/Forest.png", kost = 3, nummer = 5, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/Forest.png", kost = 3, nummer = 5, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/Forest.png", kost = 3, nummer = 5, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/Forest.png", kost = 3, nummer = 5, icoon = "", effect = "" }
            };
            AppleOrchard = new List<BlauweKaart>()
            {
                new BlauweKaart() { image = "../../Resources/AppleOrchard.png", kost = 3, nummer = 10, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/AppleOrchard.png", kost = 3, nummer = 10, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/AppleOrchard.png", kost = 3, nummer = 10, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/AppleOrchard.png", kost = 3, nummer = 10, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/AppleOrchard.png", kost = 3, nummer = 10, icoon = "", effect = "" },
                new BlauweKaart() { image = "../../Resources/AppleOrchard.png", kost = 3, nummer = 10, icoon = "", effect = "" }
            };
            //Groene kaarten lijsten
            Bakery = new List<GroeneKaart>()
            {
                new GroeneKaart() { image = "../../Resources/Bakery.jpg", kost = 1, nummer = 3, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/Bakery.jpg", kost = 1, nummer = 3, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/Bakery.jpg", kost = 1, nummer = 3, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/Bakery.jpg", kost = 1, nummer = 3, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/Bakery.jpg", kost = 1, nummer = 3, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/Bakery.jpg", kost = 1, nummer = 3, icoon = "", effect = "" }
            };
            ConvenienceStore = new List<GroeneKaart>()
            {
                new GroeneKaart() { image = "../../Resources/ConvenienceStore.png", kost = 2, nummer = 4, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/ConvenienceStore.png", kost = 2, nummer = 4, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/ConvenienceStore.png", kost = 2, nummer = 4, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/ConvenienceStore.png", kost = 2, nummer = 4, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/ConvenienceStore.png", kost = 2, nummer = 4, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/ConvenienceStore.png", kost = 2, nummer = 4, icoon = "", effect = "" }
            };
            CheeseFactory = new List<GroeneKaart>()
            {
                new GroeneKaart() { image = "../../Resources/CheeseFactory.png", kost = 5, nummer = 7, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/CheeseFactory.png", kost = 5, nummer = 7, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/CheeseFactory.png", kost = 5, nummer = 7, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/CheeseFactory.png", kost = 5, nummer = 7, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/CheeseFactory.png", kost = 5, nummer = 7, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/CheeseFactory.png", kost = 5, nummer = 7, icoon = "", effect = "" }
            };
            FurnitureFactory = new List<GroeneKaart>()
            {
                new GroeneKaart() { image = "../../Resources/FurnitureFactory.png", kost = 3, nummer = 8, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/FurnitureFactory.png", kost = 3, nummer = 8, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/FurnitureFactory.png", kost = 3, nummer = 8, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/FurnitureFactory.png", kost = 3, nummer = 8, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/FurnitureFactory.png", kost = 3, nummer = 8, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/FurnitureFactory.png", kost = 3, nummer = 8, icoon = "", effect = "" }
            };
            FruitAndVegetableMarket = new List<GroeneKaart>()
            {
                new GroeneKaart() { image = "../../Resources/FruitAndVegetableMarket.png", kost = 2, nummer = 11, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/FruitAndVegetableMarket.png", kost = 2, nummer = 11, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/FruitAndVegetableMarket.png", kost = 2, nummer = 11, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/FruitAndVegetableMarket.png", kost = 2, nummer = 11, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/FruitAndVegetableMarket.png", kost = 2, nummer = 11, icoon = "", effect = "" },
                new GroeneKaart() { image = "../../Resources/FruitAndVegetableMarket.png", kost = 2, nummer = 11, icoon = "", effect = "" }
            };
            //Rode kaarten lijsten
            Cafe = new List<RodeKaart>()
            {
                new RodeKaart() { image = "../../Resources/Cafe.png", kost = 2, nummer = 3, icoon = "", effect = "" },
                new RodeKaart() { image = "../../Resources/Cafe.png", kost = 2, nummer = 3, icoon = "", effect = "" },
                new RodeKaart() { image = "../../Resources/Cafe.png", kost = 2, nummer = 3, icoon = "", effect = "" },
                new RodeKaart() { image = "../../Resources/Cafe.png", kost = 2, nummer = 3, icoon = "", effect = "" },
                new RodeKaart() { image = "../../Resources/Cafe.png", kost = 2, nummer = 3, icoon = "", effect = "" },
                new RodeKaart() { image = "../../Resources/Cafe.png", kost = 2, nummer = 3, icoon = "", effect = "" }
            };
            FamilyRestaurant = new List<RodeKaart>()
            {
                new RodeKaart() { image = "../../Resources/FamilyRestaurant.png", kost = 3, nummer = 9, icoon = "", effect = "" },
                new RodeKaart() { image = "../../Resources/FamilyRestaurant.png", kost = 3, nummer = 9, icoon = "", effect = "" },
                new RodeKaart() { image = "../../Resources/FamilyRestaurant.png", kost = 3, nummer = 9, icoon = "", effect = "" },
                new RodeKaart() { image = "../../Resources/FamilyRestaurant.png", kost = 3, nummer = 9, icoon = "", effect = "" },
                new RodeKaart() { image = "../../Resources/FamilyRestaurant.png", kost = 3, nummer = 9, icoon = "", effect = "" },
                new RodeKaart() { image = "../../Resources/FamilyRestaurant.png", kost = 3, nummer = 9, icoon = "", effect = "" }
            };
            //Paarse kaarten lijsten
            BusinessCenter = new List<PaarseKaart>()
            {
                new PaarseKaart() { image = "../../Resources/BusinessCenter.png", kost = 8, nummer = 6, icoon = "", effect = "" },
                new PaarseKaart() { image = "../../Resources/BusinessCenter.png", kost = 8, nummer = 6, icoon = "", effect = "" },
                new PaarseKaart() { image = "../../Resources/BusinessCenter.png", kost = 8, nummer = 6, icoon = "", effect = "" },
                new PaarseKaart() { image = "../../Resources/BusinessCenter.png", kost = 8, nummer = 6, icoon = "", effect = "" }
            };
            TvStation = new List<PaarseKaart>()
            {
                new PaarseKaart() { image = "../../Resources/TvStation.png", kost = 7, nummer = 6, icoon = "", effect = "" },
                new PaarseKaart() { image = "../../Resources/TvStation.png", kost = 7, nummer = 6, icoon = "", effect = "" },
                new PaarseKaart() { image = "../../Resources/TvStation.png", kost = 7, nummer = 6, icoon = "", effect = "" },
                new PaarseKaart() { image = "../../Resources/TvStation.png", kost = 7, nummer = 6, icoon = "", effect = "" }
            };
            Stadium = new List<PaarseKaart>()
            {
                new PaarseKaart() { image = "../../Resources/Stadium.png", kost = 6, nummer = 6, icoon = "", effect = "" },
                new PaarseKaart() { image = "../../Resources/Stadium.png", kost = 6, nummer = 6, icoon = "", effect = "" },
                new PaarseKaart() { image = "../../Resources/Stadium.png", kost = 6, nummer = 6, icoon = "", effect = "" },
                new PaarseKaart() { image = "../../Resources/Stadium.png", kost = 6, nummer = 6, icoon = "", effect = "" }
            };
        }

        //Oranje kaarten methods
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
        //Blauwe kaarten methods
        public BlauweKaart GetAndRemoveWheatField()
        {
            BlauweKaart WheatFields = WheatField[0];
            return WheatFields;
        }
        public BlauweKaart GetAndRemoveRanch()
        {
            BlauweKaart Ranchs = Ranch[0];
            return Ranchs;
        }
        public BlauweKaart GetAndRemoveMine()
        {
            BlauweKaart Mines = Mine[0];
            return Mines;
        }
        public BlauweKaart GetAndRemoveForest()
        {
            BlauweKaart Forests = Forest[0];
            return Forests;
        }
        public BlauweKaart GetAndRemoveAppleOrchard()
        {
            BlauweKaart AppleOrchards = AppleOrchard[0];
            return AppleOrchards;
        }
        //Groene kaarten methods
        public GroeneKaart GetAndRemoveBakery()
        {
            GroeneKaart Bakerys = Bakery[0];
            return Bakerys;
        }
        public GroeneKaart GetAndRemoveConvenienceStore()
        {
            GroeneKaart ConvenienceStores = ConvenienceStore[0];
            return ConvenienceStores;
        }
        public GroeneKaart GetAndRemoveCheeseFactory()
        {
            GroeneKaart CheeseFactorys = CheeseFactory[0];
            return CheeseFactorys;
        }
        public GroeneKaart GetAndRemoveFurnitureFactory()
        {
            GroeneKaart FurnitureFactorys = FurnitureFactory[0];
            return FurnitureFactorys;
        }
        public GroeneKaart GetAndRemoveFruitAndVegetableMarket()
        {
            GroeneKaart FruitAndVegetableMarkets = FruitAndVegetableMarket[0];
            return FruitAndVegetableMarkets;
        }
        //Rode kaarten methods
        public RodeKaart GetAndRemoveCafe()
        {
            RodeKaart Cafes = Cafe[0];
            return Cafes;
        }
        public RodeKaart GetAndRemoveFamilyRestaurant()
        {
            RodeKaart FamilyRestaurants = FamilyRestaurant[0];
            return FamilyRestaurants;
        }
        //Paarse kaarten methods
        public PaarseKaart GetAndRemoveBusinessCenter()
        {
            PaarseKaart BusinessCenters = BusinessCenter[0];
            return BusinessCenters;
        }
        public PaarseKaart GetAndRemoveTvStation()
        {
            PaarseKaart TvStations = TvStation[0];
            return TvStations;
        }
        public PaarseKaart GetAndRemoveStadium()
        {
            PaarseKaart Stadiums = Stadium[0];
            return Stadiums;
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
    }
}
