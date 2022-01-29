using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro
{
    enum Icoon
    {
        Graan = 0,
        Koe = 1,
        Tandwiel = 2,
        Brood = 3,
        Fabriek = 4,
        Kopje = 5,
        Zwaard = 6,
        Appel = 7
    }
    enum Kaart
    {
        WheatField = 0,
        Ranch = 1,
        Mine = 2,
        Forest = 3,
        AppleOrchard = 4,
        Bakery = 5,
        ConvenienceStore = 6,
        CheeseFactory = 7,
        FurnitureFactory = 8,
        FruitAndVegetableMarket = 9,
        Cafe = 10,
        FamilyRestaurant = 11,
        BusinessCenter = 12,
        TvStation = 13,
        Stadium = 14,
    }
    static class KaartMethods
    {
        static string[] images = new string[]
        {
            "../../Resources/WheatField.png",
            "../../Resources/Ranch.png",
            "../../Resources/Mine.png",
            "../../Resources/Forest.png",
            "../../Resources/AppleOrchard.png",
            "../../Resources/Bakery.jpg",
            "../../Resources/ConvenienceStore.png",
            "../../Resources/CheeseFactory.png",
            "../../Resources/FurnitureFactory.png",
            "../../Resources/FruitAndVegetableMarket.png",
            "../../Resources/Cafe.png",
            "../../Resources/FamilyRestaurant.png",
            "../../Resources/BusinessCenter.png",
            "../../Resources/TvStation.png",
            "../../Resources/Stadium.png",
        };
        static int[] kosten = new int[]
        {
            1, 1, 6, 3, 3, 1, 2, 5, 3, 2, 2, 3, 8, 7, 6
        };
        static float[] dobbelnummer = new float[]
        {
            1, 2, 9, 5, 10, 2.5f, 4, 7, 8, 11.5f, 3, 9.5f, 6, 6, 6
        };
        static Icoon[] iconen = new Icoon[]
        {
            Icoon.Graan, Icoon.Koe, Icoon.Tandwiel, Icoon.Tandwiel, Icoon.Graan, Icoon.Brood, Icoon.Brood, Icoon.Fabriek, 
            Icoon.Fabriek, Icoon.Appel, Icoon.Kopje, Icoon.Kopje, Icoon.Zwaard, Icoon.Zwaard, Icoon.Zwaard
        };

        public static float GetDobbelNummer(this Kaart kaart)
        {
            return dobbelnummer[(int)kaart];
        }
        public static int GetKosten(this Kaart kaart)
        {
            return kosten[(int)kaart];
        }
        public static Icoon GetIcoon(this Kaart kaart)
        {
            return iconen[(int)kaart];
        }
        public static string GetImage(this Kaart kaart)
        {
            return images[(int)kaart];
        }
        public static bool Effect(this Kaart kaart, int speler, int dobbeluitkomst, int huidigespeler)
        {
            bool uitkomst = Effect2(kaart, speler, dobbeluitkomst, huidigespeler);
            if (uitkomst && Form1.OranjeKaarten[speler][1] && (kaart.GetIcoon() == Icoon.Brood || (kaart.GetIcoon() == Icoon.Kopje)))
            {
                Form1.Balances[speler] += 1;
            }
            return uitkomst;
        }
            public static bool Effect2(this Kaart kaart, int speler, int dobbeluitkomst, int huidigespeler)
        {
            if (Math.Ceiling(kaart.GetDobbelNummer()) == dobbeluitkomst || Math.Floor(kaart.GetDobbelNummer()) == dobbeluitkomst)
            {
                switch(kaart)
                {
                    case Kaart.WheatField:
                        Form1.Balances[speler] += 1;
                        return true;
                    case Kaart.Ranch:
                        Form1.Balances[speler] += 1;
                        return true;
                    case Kaart.Mine:
                        Form1.Balances[speler] += 5;
                        return true;
                    case Kaart.Forest:
                        Form1.Balances[speler] += 1;
                        return true;
                    case Kaart.AppleOrchard:
                        Form1.Balances[speler] += 3;
                        return true;
                    case Kaart.Bakery:
                        if (speler == huidigespeler)
                        {
                            Form1.Balances[speler] += 1;
                            return true;
                        }
                        return false;
                    case Kaart.ConvenienceStore:
                        if (speler == huidigespeler)
                        {
                            Form1.Balances[speler] += 3;
                            return true;
                        }
                        return false;

                    case Kaart.CheeseFactory:
                        if (speler == huidigespeler)
                        {
                            int som = 0;
                            for (int i = 0; i < Form1.spelers[speler].SpelerKaarten.Count; i++)
                            {

                                if (Form1.spelers[speler].SpelerKaarten[i].GetIcoon() == Icoon.Koe)
                                {
                                    som++;
                                }
                            }
                            Form1.Balances[speler] += som * 3;
                            return true;
                        }
                        return false;
                    case Kaart.FurnitureFactory:
                        if (speler == huidigespeler)
                        {
                            int som = 0;
                            for (int i = 0; i < Form1.spelers[speler].SpelerKaarten.Count; i++)
                            {

                                if (Form1.spelers[speler].SpelerKaarten[i].GetIcoon() == Icoon.Tandwiel)
                                {
                                    som++;
                                }
                            }
                            Form1.Balances[speler] += som * 3;
                            return true;
                        }
                        return false;
                    case Kaart.FruitAndVegetableMarket:
                        if (speler == huidigespeler)
                        {
                            int som = 0;
                            for (int i = 0; i < Form1.spelers[speler].SpelerKaarten.Count; i++)
                            {

                                if (Form1.spelers[speler].SpelerKaarten[i].GetIcoon() == Icoon.Graan)
                                {
                                    som++;
                                }
                            }
                            Form1.Balances[speler] += som * 2;
                            return true;
                        }
                        return false;
                    case Kaart.Cafe:
                        if (Form1.Balances[huidigespeler] == 0)
                        {
                            return false;
                        }
                        Form1.Balances[huidigespeler] -= 1;
                        Form1.Balances[speler] += 1;
                        return true;

                    case Kaart.FamilyRestaurant:
                        if (Form1.Balances[huidigespeler] == 0)
                        {
                            return false;
                        }
                        if (Form1.Balances[huidigespeler] == 1)
                        {
                            Form1.Balances[huidigespeler] -= 1;
                            Form1.Balances[speler] += 1;
                            return true;
                        }
                        Form1.Balances[huidigespeler] -= 2;
                        Form1.Balances[speler] += 2;
                        return true;

                        //Geen idee
                    case Kaart.BusinessCenter:
                        return false;
                    case Kaart.TvStation:
                        return true;

                    case Kaart.Stadium:
                        if (speler == huidigespeler)
                        {
                            for (int i = 0; i < 4 ; i++)
                            {
                                if (i != speler)
                                {
                                    int AantalMunten = Math.Min(2, Form1.Balances[i]);
                                    Form1.Balances[i] -= AantalMunten;
                                    Form1.Balances[speler] += AantalMunten;
                                    
                                }
                            }
                            return true;
                        }
                        return false;
                    default: 
                        return false;
                }
            }
            return false;
        }
    }
}
