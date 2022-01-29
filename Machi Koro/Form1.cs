using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Machi_Koro
{
    public partial class Form1 : Form
    {

        Dobbelsteen Dobbelstenen = new Dobbelsteen();
        Object[] test = new Object[] { 1, 2 };
        int AantalMensen = 1;
        public static int[] Balances = new int[4];
        int HuidigeSpeler = 0;

        Button[][] KoopKnoppen;
        Label[] SpelerLabels;
        internal static Speler[] spelers;
        internal static bool[][] OranjeKaarten;
        bool doubles = false;
        bool gerold = false;
        static Random rand = new Random();

        int P1Kaarten = 0;
        int P2Kaarten = 0;
        int P3Kaarten = 0;
        int P4Kaarten = 0;
        List<PictureBox> DobbelsteenPicturebox = new List<PictureBox>();

        PictureBox[][] PlayerHands;

        public Form1()
        {
            InitializeComponent();
            SpelerLabels = new Label[]
            {
                Player1L, Player2L, Player3L, Player4L
            };
            NumSpelerBox.SelectedIndex = 0;
            StartSpel.Enabled = false;
            DobbelsteenPicturebox.Add(Dobbel1P);
            DobbelsteenPicturebox.Add(Dobbel2P);
            Dobbel1.Enabled = false;
            Dobbel2.Enabled = false;
            KoopKnoppenUit();

            
            BalP1.Text = "Balance: 0";
            BalP2.Text = "Balance: 0";
            BalP3.Text = "Balance: 0";
            BalP4.Text = "Balance: 0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Dobbel1_Click(object sender, EventArgs e)
        {
            Dobbel dobbel = Dobbelstenen.RandomNummer();
            Dobbel1P.ImageLocation = Path.GetFullPath(dobbel.image);
            int uitkomst = dobbel.dobbelnummer;
            CheckEffecten(uitkomst);
            Dobbel1.Enabled = false;
            Dobbel2.Enabled = false;
            for (int button = 0; button < 4; button++)
            {
                if (!OranjeKaarten[HuidigeSpeler][button])
                {
                    KoopKnoppen[HuidigeSpeler][button].Enabled = true;
                }
            }
            EindigBeurtBtn.Enabled = true;
            gerold = true;
        }

        private void Dobbel2_Click(object sender, EventArgs e)
        {
            Dobbel dobbel = Dobbelstenen.RandomNummer();
            Dobbel1P.ImageLocation = Path.GetFullPath(dobbel.image);
            int uitkomst1 = dobbel.dobbelnummer;
            dobbel = Dobbelstenen.RandomNummer();
            Dobbel2P.ImageLocation = Path.GetFullPath(dobbel.image);
            int uitkomst2 = dobbel.dobbelnummer;
            CheckEffecten(uitkomst1 + uitkomst2);
            Dobbel1.Enabled = false;
            Dobbel2.Enabled = false;
            for (int button = 0; button < 4; button++)
            {
                if (!OranjeKaarten[HuidigeSpeler][button])
                {
                    KoopKnoppen[HuidigeSpeler][button].Enabled = true;
                }
            }
            EindigBeurtBtn.Enabled = true;
            if (uitkomst1 == uitkomst2 && OranjeKaarten[HuidigeSpeler][2])
            {
                doubles = true;
            }
            gerold = true;
            
        }

        private void StartSpel_Click(object sender, EventArgs e)
        {
            spelers = new Speler[]
            {
                new Speler(), new Speler(), new Speler(), new Speler()
            };
            PlayerHands = new PictureBox[][]
            {
                new PictureBox[]
                {
                    P11, P12, P13, P14, P15, P16, P17, P18, P19, P110, P111, P112, P113, P114, P115, P116
                },
                new PictureBox[]
                {
                    P21, P22, P23, P24, P25, P26, P27, P28, P29, P210, P211, P212, P213, P214, P215, P216
                },
                new PictureBox[]
                {
                    P31, P32, P33, P34, P35, P36, P37, P38, P39, P310, P311, P312, P313, P314, P315, P316
                },
                new PictureBox[]
                {
                    P41, P42, P43, P44, P45, P46, P47, P48, P49, P410, P411, P412, P413, P414, P415, P416
                }
            };
            OranjeKaarten = new bool[][]
            {
                new bool[4], new bool[4], new bool[4], new bool[4]
            };
            AantalMensen = Int32.Parse((string) NumSpelerBox.SelectedItem);
            StartSpel.Enabled = false;
            Dobbel1.Enabled = true;
            Dobbel2.Enabled = false;


            for (int speler = 0; speler < 4; speler++)
            {
                spelers[speler].VoegKaartToe(Kaart.WheatField);
                spelers[speler].VoegKaartToe(Kaart.Bakery);
                UpdateKaarten(speler);
            }

            KoopKnoppenUit();

            HuidigeSpeler = 3;
            EindigBeurt();
            NumSpelerBox.Enabled = false;

            Balances[0] = 3;
            Balances[1] = 3;
            Balances[2] = 3;
            Balances[3] = 3;

            BalP1.Text = "Balance: " + Balances[0];
            BalP2.Text = "Balance: " + Balances[1];
            BalP3.Text = "Balance: " + Balances[2];
            BalP4.Text = "Balance: " + Balances[3];

            //Blauwe Speelkaarten
            
            WheatFieldPBox.ImageLocation = Path.GetFullPath(Kaart.WheatField.GetImage());
            RanchPBox.ImageLocation = Path.GetFullPath(Kaart.Ranch.GetImage());
            MinePBox.ImageLocation = Path.GetFullPath(Kaart.Mine.GetImage());
            ForestPBox.ImageLocation = Path.GetFullPath(Kaart.Forest.GetImage()); ;
            AppleOrchardPBox.ImageLocation = Path.GetFullPath(Kaart.AppleOrchard.GetImage());

            //Groene Speelkaarten
            BakeryPBox.ImageLocation = Path.GetFullPath(Kaart.Bakery.GetImage());
            ConvenienceStorePBox.ImageLocation = Path.GetFullPath(Kaart.ConvenienceStore.GetImage());
            CheeseFactoryPBox.ImageLocation = Path.GetFullPath(Kaart.CheeseFactory.GetImage());
            FurnitureFactoryPBox.ImageLocation = Path.GetFullPath(Kaart.FurnitureFactory.GetImage());
            FruitAndVegetableMarketPBox.ImageLocation = Path.GetFullPath(Kaart.FruitAndVegetableMarket.GetImage());

            //Rode Speelkaarten
            CafePBox.ImageLocation = Path.GetFullPath(Kaart.Cafe.GetImage());
            FamilyRestaurantPBox.ImageLocation = Path.GetFullPath(Kaart.FamilyRestaurant.GetImage());
            //Paarse Speelkaarten
            BusinessCenterPBox.ImageLocation = Path.GetFullPath(Kaart.BusinessCenter.GetImage());
            TvStationPBox.ImageLocation = Path.GetFullPath(Kaart.TvStation.GetImage());
            StadiumPBox.ImageLocation = Path.GetFullPath(Kaart.Stadium.GetImage());

            //P1
            P1OK1.ImageLocation = Path.GetFullPath("../../Resources/TrainStationB.png");
            P1OK2.ImageLocation = Path.GetFullPath("../../Resources/ShoppingMallB.png");
            P1OK3.ImageLocation = Path.GetFullPath("../../Resources/AmusementParkB.png");
            P1OK4.ImageLocation = Path.GetFullPath("../../Resources/RadioTowerB.png");

            //P2
            P2OK1.ImageLocation = Path.GetFullPath("../../Resources/TrainStationB.png");
            P2OK2.ImageLocation = Path.GetFullPath("../../Resources/ShoppingMallB.png");
            P2OK3.ImageLocation = Path.GetFullPath("../../Resources/AmusementParkB.png");
            P2OK4.ImageLocation = Path.GetFullPath("../../Resources/RadioTowerB.png");

            //P3
            P3OK1.ImageLocation = Path.GetFullPath("../../Resources/TrainStationB.png");
            P3OK2.ImageLocation = Path.GetFullPath("../../Resources/ShoppingMallB.png");
            P3OK3.ImageLocation = Path.GetFullPath("../../Resources/AmusementParkB.png");
            P3OK4.ImageLocation = Path.GetFullPath("../../Resources/RadioTowerB.png");

            //P4
            P4OK1.ImageLocation = Path.GetFullPath("../../Resources/TrainStationB.png");
            P4OK2.ImageLocation = Path.GetFullPath("../../Resources/ShoppingMallB.png");
            P4OK3.ImageLocation = Path.GetFullPath("../../Resources/AmusementParkB.png");
            P4OK4.ImageLocation = Path.GetFullPath("../../Resources/RadioTowerB.png");
        }

        //Koop knoppen P1
        private void KoopP1_Click(object sender, EventArgs e)
        {
            if (Balances[0] >= 4)
            {
                P1OK1.ImageLocation = Path.GetFullPath("../../Resources/TrainStation.png");
                Balances[0] -= 4;
                KoopP1.Enabled = false;
                BalP1.Text = "Balance: " + Balances[0];
                P1Kaarten += 1;
                OranjeKaarten[0][0] = true;
                WinChecker();
                EindigBeurt();
            }
        }

        private void KoopP2_Click(object sender, EventArgs e)
        {
            if (Balances[0] >= 10)
            {
                P1OK2.ImageLocation = Path.GetFullPath("../../Resources/ShoppingMall.png");
                Balances[0] -= 10;
                KoopP2.Enabled = false;
                BalP1.Text = "Balance: " + Balances[0];
                P1Kaarten += 1;
                OranjeKaarten[0][1] = true;
                WinChecker();
                EindigBeurt();
            }
        }

        private void KoopP3_Click(object sender, EventArgs e)
        {
            if (Balances[0] >= 16)
            {
                P1OK3.ImageLocation = Path.GetFullPath("../../Resources/AmusementPark.png");
                Balances[0] -= 16;
                KoopP3.Enabled = false;
                BalP1.Text = "Balance: " + Balances[0];
                P1Kaarten += 1;
                OranjeKaarten[0][2] = true;
                WinChecker();
                EindigBeurt();
            }
        }

        private void KoopP4_Click(object sender, EventArgs e)
        {
            if (Balances[0] >= 22)
            {
                P1OK4.ImageLocation = Path.GetFullPath("../../Resources/RadioTower.png");
                Balances[0] -= 22;
                KoopP4.Enabled = false;
                BalP1.Text = "Balance: " + Balances[0];
                P1Kaarten += 1;
                OranjeKaarten[0][3] = true;
                WinChecker();
                EindigBeurt();
            }
        }


        //Koop knoppen P2
        private void KoopP5_Click(object sender, EventArgs e)
        {
            if (Balances[1] >= 4)
            {
                P2OK1.ImageLocation = Path.GetFullPath("../../Resources/TrainStation.png");
                Balances[1] -= 4;
                KoopP5.Enabled = false;
                BalP2.Text = "Balance: " + Balances[1];
                P2Kaarten += 1;
                OranjeKaarten[1][0] = true;
                WinChecker();
                EindigBeurt();
            }
        }

        private void KoopP6_Click(object sender, EventArgs e)
        {
            if (Balances[1] >= 10)
            {
                P2OK2.ImageLocation = Path.GetFullPath("../../Resources/ShoppingMall.png");
                Balances[1] -= 10;
                KoopP6.Enabled = false;
                BalP2.Text = "Balance: " + Balances[1];
                P2Kaarten += 1;
                OranjeKaarten[1][1] = true;
                WinChecker();
                EindigBeurt();
            }
        }

        private void KoopP7_Click(object sender, EventArgs e)
        {
            if (Balances[1] >= 16)
            {
                P2OK3.ImageLocation = Path.GetFullPath("../../Resources/AmusementPark.png");
                Balances[1] -= 16;
                KoopP7.Enabled = false;
                BalP2.Text = "Balance: " + Balances[1];
                P2Kaarten += 1;
                OranjeKaarten[1][2] = true;
                WinChecker();
                EindigBeurt();
            }
        }

        private void KoopP8_Click(object sender, EventArgs e)
        {
            if (Balances[1] >= 22)
            { 
                P2OK4.ImageLocation = Path.GetFullPath("../../Resources/RadioTower.png");
                Balances[1] -= 22;
                KoopP8.Enabled = false;
                BalP2.Text = "Balance: " + Balances[1];
                P2Kaarten += 1;
                OranjeKaarten[1][3] = true;
                WinChecker();
                EindigBeurt();
            }
        }


        //Koop knoppen P3
        private void KoopP9_Click(object sender, EventArgs e)
        {
            if (Balances[2] >= 4)
            {
                P3OK1.ImageLocation = Path.GetFullPath("../../Resources/TrainStation.png");
                Balances[2] -= 4;
                KoopP9.Enabled = false;
                BalP3.Text = "Balance: " + Balances[2];
                P3Kaarten += 1;
                OranjeKaarten[2][0] = true;
                WinChecker();
                EindigBeurt();
            }
        }

        private void KoopP10_Click(object sender, EventArgs e)
        {
            if (Balances[2] >= 10)
            {
                P3OK2.ImageLocation = Path.GetFullPath("../../Resources/ShoppingMall.png");
                Balances[2] -= 10;
                KoopP10.Enabled = false;
                BalP3.Text = "Balance: " + Balances[2];
                P3Kaarten += 1;
                OranjeKaarten[2][1] = true;
                WinChecker();
                EindigBeurt();
            }
        }

        private void KoopP11_Click(object sender, EventArgs e)
        {
            if (Balances[2] >= 16)
            {
                P3OK3.ImageLocation = Path.GetFullPath("../../Resources/AmusementPark.png");
                Balances[2] -= 16;
                KoopP11.Enabled = false;
                BalP3.Text = "Balance: " + Balances[2];
                P3Kaarten += 1;
                OranjeKaarten[2][2] = true;
                WinChecker();
                EindigBeurt();
            }
        }

        private void KoopP12_Click(object sender, EventArgs e)
        {
            if (Balances[2] >= 22)
            {
                P3OK4.ImageLocation = Path.GetFullPath("../../Resources/RadioTower.png");
                Balances[2] -= 22;
                KoopP12.Enabled = false;
                BalP3.Text = "Balance: " + Balances[2];
                P3Kaarten += 1;
                OranjeKaarten[2][3] = true;
                WinChecker();
                EindigBeurt();
            }
        }


        //Koop knoppen P4
        private void KoopP13_Click(object sender, EventArgs e)
        {
            if (Balances[3] >= 4)
            {
                P4OK1.ImageLocation = Path.GetFullPath("../../Resources/TrainStation.png");
                Balances[3] -= 4;
                KoopP13.Enabled = false;
                BalP4.Text = "Balance: " + Balances[3];
                P4Kaarten += 1;
                OranjeKaarten[3][0] = true;
                WinChecker();
                EindigBeurt();
            }
        }

        private void KoopP14_Click(object sender, EventArgs e)
        {
            if (Balances[3] >= 10)
            {
                P4OK2.ImageLocation = Path.GetFullPath("../../Resources/ShoppingMall.png");
                Balances[3] -= 10;
                KoopP14.Enabled = false;
                BalP4.Text = "Balance: " + Balances[3];
                P4Kaarten += 1;
                OranjeKaarten[3][1] = true;
                WinChecker();
                EindigBeurt();
            }
        }

        private void KoopP15_Click(object sender, EventArgs e)
        {
            if (Balances[3] >= 16)
            {
                P4OK3.ImageLocation = Path.GetFullPath("../../Resources/AmusementPark.png");
                Balances[3] -= 16;
                KoopP15.Enabled = false;
                BalP4.Text = "Balance: " + Balances[3];
                P4Kaarten += 1;
                OranjeKaarten[3][2] = true;
                WinChecker();
                EindigBeurt();
            }
        }

        private void KoopP16_Click(object sender, EventArgs e)
        {
            if (Balances[3] >= 22)
            {
                P4OK4.ImageLocation = Path.GetFullPath("../../Resources/RadioTower.png");
                Balances[3] -= 22;
                KoopP16.Enabled = false;
                BalP4.Text = "Balance: " + Balances[3];
                P4Kaarten += 1;
                OranjeKaarten[3][3] = true;
                WinChecker();
                EindigBeurt();
            }
        }
        public void UpdateBalance()
        {
            BalP1.Text = "Balance: " + Balances[0];
            BalP2.Text = "Balance: " + Balances[1];
            BalP3.Text = "Balance: " + Balances[2];
            BalP4.Text = "Balance: " + Balances[3];
        }

        public void KoopKnoppenUit()
        {
            KoopKnoppen = new Button[][]
            {
                new Button[]{
                    KoopP1,KoopP2,KoopP3,KoopP4
                },
                new Button[]{
                    KoopP5,KoopP6,KoopP7,KoopP8
                },
                new Button[]{
                    KoopP9,KoopP10,KoopP11,KoopP12
                },
                new Button[]{
                    KoopP13,KoopP14,KoopP15,KoopP16
                }
            };
            KoopP1.Enabled = false;
            KoopP2.Enabled = false;
            KoopP3.Enabled = false;
            KoopP4.Enabled = false;

            KoopP5.Enabled = false;
            KoopP6.Enabled = false;
            KoopP7.Enabled = false;
            KoopP8.Enabled = false;

            KoopP9.Enabled = false;
            KoopP10.Enabled = false;
            KoopP11.Enabled = false;
            KoopP12.Enabled = false;
            KoopP13.Enabled = false;
            KoopP14.Enabled = false;
            KoopP15.Enabled = false;
            KoopP16.Enabled = false;
        }
        public void KoopKnoppenAan()
        {
            KoopP1.Enabled = true;
            KoopP2.Enabled = true;
            KoopP3.Enabled = true;
            KoopP4.Enabled = true;
            KoopP5.Enabled = true;
            KoopP6.Enabled = true;
            KoopP7.Enabled = true;
            KoopP8.Enabled = true;
            KoopP9.Enabled = true;
            KoopP10.Enabled = true;
            KoopP11.Enabled = true;
            KoopP12.Enabled = true;
            KoopP13.Enabled = true;
            KoopP14.Enabled = true;
            KoopP15.Enabled = true;
            KoopP16.Enabled = true;
        }
        public void WinChecker()
        {
            if (P1Kaarten == 4)
            {
                MessageBox.Show("Speler 1 heeft gewonnen!");
                P1Kaarten = 0;
            }
            if (P2Kaarten == 4)
            {
                MessageBox.Show("Speler 2 heeft gewonnen!");
                P2Kaarten = 0;
            }
            if (P3Kaarten == 4)
            {
                MessageBox.Show("Speler 3 heeft gewonnen!");
                P3Kaarten = 0;
            }
            if (P4Kaarten == 4)
            {
                MessageBox.Show("Speler 4 heeft gewonnen!");
                P4Kaarten = 0;
            }
        }

        public void CheckEffecten(int uitkomst)
        {
            for (int speler = 0 ; speler < 4; speler++)
            {
                for (int i = 0 ; i < spelers[speler].SpelerKaarten.Count; i++)
                {
                    spelers[speler].SpelerKaarten[i].Effect(speler, uitkomst, HuidigeSpeler);
                }
            }
            UpdateBalance();
        }
        
        private void NumSpelerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NumSpelerBox.SelectedIndex == 0)
            {
                StartSpel.Enabled = false;
            }
            else
            {
                StartSpel.Enabled= true;
            }
        }
        public void EindigBeurt()
        {
            if (doubles)
            {
                HuidigeSpeler -= 1;
                doubles = false;
            }
            SpelerLabels[HuidigeSpeler].BackColor = Color.White;
            SpelerLabels[HuidigeSpeler].ForeColor = Color.Black;
            for (int button = 0 ; button < 4 ; button++)
            {
                KoopKnoppen[HuidigeSpeler][button].Enabled = false;
            }
            HuidigeSpeler = (HuidigeSpeler + 1) %4;
            SpelerLabels[HuidigeSpeler].BackColor = Color.Black;
            SpelerLabels[HuidigeSpeler].ForeColor = Color.White;
            if (OranjeKaarten[HuidigeSpeler][0])
            {
                Dobbel2.Enabled = true;
            }
            else
            {
                Dobbel2.Enabled= false;
                Dobbel2P.ImageLocation = null;
            }
            Dobbel1.Enabled = true;
            EindigBeurtBtn.Enabled = false;
            gerold = false;
            if (HuidigeSpeler >= AantalMensen)
            {
                AIMethod(); 
            }
        }
        public void AIMethod()
        {
            int speler = HuidigeSpeler;
            if (OranjeKaarten[HuidigeSpeler][0])
            {
                Dobbel2_Click(null, null);
            }
            else
            {
                Dobbel1_Click(null, null);
            }
            if (!OranjeKaarten[HuidigeSpeler][0])
            {
                switch (HuidigeSpeler)
                {
                    case 1:
                        KoopP5_Click(null, null);
                        break;
                    case 2:
                        KoopP9_Click(null, null);
                        break;
                    case 3:
                        KoopP13_Click(null, null);
                        break;
                }

            }
            else if (!OranjeKaarten[HuidigeSpeler][1])
            {
                switch (HuidigeSpeler)
                {
                    case 1:
                        KoopP6_Click(null, null);
                        break;
                    case 2:
                        KoopP10_Click(null, null);
                        break;
                    case 3:
                        KoopP14_Click(null, null);
                        break;
                }
            }
            else if (!OranjeKaarten[HuidigeSpeler][2])
            {
                switch (HuidigeSpeler)
                {
                    case 1:
                        KoopP7_Click(null, null);
                        break;
                    case 2:
                        KoopP11_Click(null, null);
                        break;
                    case 3:
                        KoopP15_Click(null, null);
                        break;
                }
            }
            else if (!OranjeKaarten[HuidigeSpeler][3])
            {
                switch (HuidigeSpeler)
                {
                    case 1:
                        KoopP8_Click(null, null);
                        break;
                    case 2:
                        KoopP12_Click(null, null);
                        break;
                    case 3:
                        KoopP16_Click(null, null);
                        break;
                }
            }
            if (speler == HuidigeSpeler)
            {
                List<Kaart> kaartopties = new List<Kaart>();
                foreach (Kaart kaart in Enum.GetValues(typeof(Kaart)))
                {
                    if (Balances[HuidigeSpeler] >= kaart.GetKosten())
                    {
                        kaartopties.Add(kaart);
                    }
                }
                if (kaartopties.Count > 0)
                {
                    KoopKaart2(kaartopties[rand.Next(kaartopties.Count)]);
                }
                else
                {
                    EindigBeurt();
                }
            }
        }

        private void EindigBeurtBtn_Click(object sender, EventArgs e)
        {
            EindigBeurt();
        }
        private void OpenPictureBox(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Image == null)
            {
                return;
            }
            BigPicBox.Image = ((PictureBox)sender).Image;
            BigPicBox.Visible = true;
        }
        private void ClosePictureBox(object sender, EventArgs e)
        {
            BigPicBox.Visible = false;
        }
        private void KoopKaart2(Kaart kaart)
        {
            if (gerold && Balances[HuidigeSpeler] >= kaart.GetKosten() && spelers[HuidigeSpeler].SpelerKaarten.Count < 16)
            {
                spelers[HuidigeSpeler].VoegKaartToe(kaart);
                Balances[HuidigeSpeler] -= kaart.GetKosten();
                UpdateBalance();
                UpdateKaarten(HuidigeSpeler);
                EindigBeurt();
            }
        }

        private void KoopKaart(object sender, EventArgs e)
        {
            string naam = ((PictureBox)sender).Name.Substring(0, ((PictureBox)sender).Name.Length - 4);
            Kaart kaart = (Kaart)Enum.Parse(typeof(Kaart), naam);
            KoopKaart2(kaart);         
        }
        private void UpdateKaarten(int speler)
        {
            for (int i = 0; i < spelers[speler].SpelerKaarten.Count ; i++)
            {
                PlayerHands[speler][i].ImageLocation = Path.GetFullPath(spelers[speler].SpelerKaarten[i].GetImage());
            }
        }

        private void SpelRegels_Click(object sender, EventArgs e)
        {
            Spelregels spelregels = new Spelregels();
            spelregels.Show();
        }
    }
}


