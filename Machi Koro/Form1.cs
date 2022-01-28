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
        Speler speler = new Speler();
        Dobbelsteen Dobbelstenen = new Dobbelsteen();
        Kaart OranjeKaarten = new Kaart();
        Kaart BlauweKaarten = new Kaart();
        Kaart GroeneKaarten = new Kaart();
        Kaart RodeKaarten = new Kaart();
        Kaart PaarseKaarten = new Kaart();

        int AantalSpelers = 2;

        int BalanceP1 = 0;
        int BalanceP2 = 0;
        int BalanceP3 = 0;
        int BalanceP4 = 0;
        int P1Kaarten = 0;
        int P2Kaarten = 0;
        int P3Kaarten = 0;
        int P4Kaarten = 0;

        List<PictureBox> DobbelsteenPicturebox = new List<PictureBox>();
        List<PictureBox> P1Picturebox = new List<PictureBox>();
        List<PictureBox> P2Picturebox = new List<PictureBox>();
        List<PictureBox> P3Picturebox = new List<PictureBox>();
        List<PictureBox> P4Picturebox = new List<PictureBox>();



        public Form1()
        {
            InitializeComponent();
            
            DobbelsteenPicturebox.Add(Dobbel1P);
            DobbelsteenPicturebox.Add(Dobbel2P);
            Dobbel1.Enabled = false;
            Dobbel2.Enabled = false;
            KoopKnoppenUit();

            BalanceP1 = 0;
            BalP1.Text = "Balance: " + BalanceP1;
            BalanceP2 = 0;
            BalP2.Text = "Balance: " + BalanceP2;
            BalanceP3 = 0;
            BalP3.Text = "Balance: " + BalanceP3;
            BalanceP4 = 0;
            BalP4.Text = "Balance: " + BalanceP4;
            LabelBlank();
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
        }

        private void Dobbel2_Click(object sender, EventArgs e)
        {
            Dobbel dobbel = Dobbelstenen.RandomNummer();
            Dobbel1P.ImageLocation = Path.GetFullPath(dobbel.image);

            int uitkomst = dobbel.dobbelnummer;

            dobbel = Dobbelstenen.RandomNummer();
            Dobbel2P.ImageLocation = Path.GetFullPath(dobbel.image);
            uitkomst += dobbel.dobbelnummer;
            CheckEffecten(uitkomst);
        }

        private void StartSpel_Click(object sender, EventArgs e)
        {
            StartSpel.Enabled = false;
            Dobbel1.Enabled = true;
            Dobbel2.Enabled = true;

            KoopKnoppenAan();

            BalanceP1 = 103;
            BalanceP2 = 103;
            BalanceP3 = 103;
            BalanceP4 = 103;

            BalP1.Text = "Balance: " + BalanceP1;
            BalP2.Text = "Balance: " + BalanceP2;
            BalP3.Text = "Balance: " + BalanceP3;
            BalP4.Text = "Balance: " + BalanceP4;

            //Blauwe Speelkaarten
            BlauweKaart Wheatfield = BlauweKaarten.GetAndRemoveWheatField();
            WheatFieldPBox.ImageLocation = Path.GetFullPath(Wheatfield.image);
            WheatFieldL.Text = "6";

            BlauweKaart Ranch = BlauweKaarten.GetAndRemoveRanch();
            RanchPBox.ImageLocation = Path.GetFullPath(Ranch.image);
            RanchL.Text = "6";

            BlauweKaart Mine = BlauweKaarten.GetAndRemoveMine();
            MinePBox.ImageLocation = Path.GetFullPath(Mine.image);
            MineL.Text = "6";

            BlauweKaart Forest = BlauweKaarten.GetAndRemoveForest();
            ForestPBox.ImageLocation = Path.GetFullPath(Forest.image);
            ForestL.Text = "6";

            BlauweKaart AppleOrchard = BlauweKaarten.GetAndRemoveAppleOrchard();
            AppleOrchardPBox.ImageLocation = Path.GetFullPath(AppleOrchard.image);
            AppleOrchardL.Text = "6";

            //Groene Speelkaarten
            GroeneKaart Bakery = GroeneKaarten.GetAndRemoveBakery();
            BakeryPBox.ImageLocation = Path.GetFullPath(Bakery.image);
            BakeryL.Text = "6";

            GroeneKaart ConvenienceStore = GroeneKaarten.GetAndRemoveConvenienceStore();
            ConvenienceStorePBox.ImageLocation = Path.GetFullPath(ConvenienceStore.image);
            ConvenienceStoreL.Text = "6";

            GroeneKaart CheeseFactory = GroeneKaarten.GetAndRemoveCheeseFactory();
            CheeseFactoryPBox.ImageLocation = Path.GetFullPath(CheeseFactory.image);
            CheeseFactoryL.Text = "6";

            GroeneKaart FurnitureFactory = GroeneKaarten.GetAndRemoveFurnitureFactory();
            FurnitureFactoryPBox.ImageLocation = Path.GetFullPath(FurnitureFactory.image);
            FurnitureFactoryL.Text = "6";

            GroeneKaart FruitAndVegetableMarket = GroeneKaarten.GetAndRemoveFruitAndVegetableMarket();
            FruitAndVegetableMarketPBox.ImageLocation = Path.GetFullPath(FruitAndVegetableMarket.image);
            FruitAndVegetableMarketL.Text = "6";

            //Rode Speelkaarten
            RodeKaart Cafe = RodeKaarten.GetAndRemoveCafe();
            CafePBox.ImageLocation = Path.GetFullPath(Cafe.image);
            CafeL.Text = "6";

            RodeKaart FamilyRestaurant = RodeKaarten.GetAndRemoveFamilyRestaurant();
            FamilyRestaurantPBox.ImageLocation = Path.GetFullPath(FamilyRestaurant.image);
            FamilyRestaurantL.Text = "6";

            //Paarse Speelkaarten
            PaarseKaart BusinessCenter = PaarseKaarten.GetAndRemoveBusinessCenter();
            BusinessCenterPBox.ImageLocation = Path.GetFullPath(BusinessCenter.image);
            BusinessCenterL.Text = "4";

            PaarseKaart TvStation = PaarseKaarten.GetAndRemoveTvStation();
            TvStationPBox.ImageLocation = Path.GetFullPath(TvStation.image);
            TvStationL.Text = "4";

            PaarseKaart Stadium = PaarseKaarten.GetAndRemoveStadium();
            StadiumPBox.ImageLocation = Path.GetFullPath(Stadium.image);
            StadiumL.Text = "4";

            //P1
            OranjeKaart oranjekaart1 = OranjeKaarten.GetAndRemoveOranjeKaartB();
            P1OK1.ImageLocation = Path.GetFullPath(oranjekaart1.image);
            OranjeKaarten.RemoveOranjeKaartB();
            OranjeKaart oranjekaart2 = OranjeKaarten.GetAndRemoveOranjeKaartB();
            P1OK2.ImageLocation = Path.GetFullPath(oranjekaart2.image);
            OranjeKaarten.RemoveOranjeKaartB();
            OranjeKaart oranjekaart3 = OranjeKaarten.GetAndRemoveOranjeKaartB();
            P1OK3.ImageLocation = Path.GetFullPath(oranjekaart3.image);
            OranjeKaarten.RemoveOranjeKaartB();
            OranjeKaart oranjekaart4 = OranjeKaarten.GetAndRemoveOranjeKaartB();
            P1OK4.ImageLocation = Path.GetFullPath(oranjekaart4.image);
            OranjeKaarten.RemoveOranjeKaartB();

            //P2
            OranjeKaarten.NieuweOranjeKaartenB();
            OranjeKaart oranjekaart5 = OranjeKaarten.GetAndRemoveOranjeKaartB();
            P2OK1.ImageLocation = Path.GetFullPath(oranjekaart5.image);
            OranjeKaarten.RemoveOranjeKaartB();
            OranjeKaart oranjekaart6 = OranjeKaarten.GetAndRemoveOranjeKaartB();
            P2OK2.ImageLocation = Path.GetFullPath(oranjekaart6.image);
            OranjeKaarten.RemoveOranjeKaartB();
            OranjeKaart oranjekaart7 = OranjeKaarten.GetAndRemoveOranjeKaartB();
            P2OK3.ImageLocation = Path.GetFullPath(oranjekaart7.image);
            OranjeKaarten.RemoveOranjeKaartB();
            OranjeKaart oranjekaart8 = OranjeKaarten.GetAndRemoveOranjeKaartB();
            P2OK4.ImageLocation = Path.GetFullPath(oranjekaart8.image);
            OranjeKaarten.RemoveOranjeKaartB();

            //P3
            OranjeKaarten.NieuweOranjeKaartenB();
            OranjeKaart oranjekaart9 = OranjeKaarten.GetAndRemoveOranjeKaartB();
            P3OK1.ImageLocation = Path.GetFullPath(oranjekaart9.image);
            OranjeKaarten.RemoveOranjeKaartB();
            OranjeKaart oranjekaart10 = OranjeKaarten.GetAndRemoveOranjeKaartB();
            P3OK2.ImageLocation = Path.GetFullPath(oranjekaart10.image);
            OranjeKaarten.RemoveOranjeKaartB();
            OranjeKaart oranjekaart11 = OranjeKaarten.GetAndRemoveOranjeKaartB();
            P3OK3.ImageLocation = Path.GetFullPath(oranjekaart11.image);
            OranjeKaarten.RemoveOranjeKaartB();
            OranjeKaart oranjekaart12 = OranjeKaarten.GetAndRemoveOranjeKaartB();
            P3OK4.ImageLocation = Path.GetFullPath(oranjekaart12.image);
            OranjeKaarten.RemoveOranjeKaartB();

            //P4
            OranjeKaarten.NieuweOranjeKaartenB();
            OranjeKaart oranjekaart13 = OranjeKaarten.GetAndRemoveOranjeKaartB();
            P4OK1.ImageLocation = Path.GetFullPath(oranjekaart13.image);
            OranjeKaarten.RemoveOranjeKaartB();
            OranjeKaart oranjekaart14 = OranjeKaarten.GetAndRemoveOranjeKaartB();
            P4OK2.ImageLocation = Path.GetFullPath(oranjekaart14.image);
            OranjeKaarten.RemoveOranjeKaartB();
            OranjeKaart oranjekaart15 = OranjeKaarten.GetAndRemoveOranjeKaartB();
            P4OK3.ImageLocation = Path.GetFullPath(oranjekaart15.image);
            OranjeKaarten.RemoveOranjeKaartB();
            OranjeKaart oranjekaart16 = OranjeKaarten.GetAndRemoveOranjeKaartB();
            P4OK4.ImageLocation = Path.GetFullPath(oranjekaart16.image);
            OranjeKaarten.RemoveOranjeKaartB();
        }

        //Koop knoppen P1
        private void KoopP1_Click(object sender, EventArgs e)
        {
            if (BalanceP1 >= 4)
            {
                OranjeKaart oranjekaart1P1 = OranjeKaarten.GetAndRemoveOranjeKaart();
                P1OK1.ImageLocation = Path.GetFullPath(oranjekaart1P1.image);
                BalanceP1 -= 4;
                KoopP1.Enabled = false;
                BalP1.Text = "Balance: " + BalanceP1;
                P1Kaarten += 1;
                WinChecker();
            }
        }

        private void KoopP2_Click(object sender, EventArgs e)
        {
            if (BalanceP1 >= 10)
            {
                OranjeKaart oranjekaart2P1 = OranjeKaarten.GetAndRemoveOranjeKaart2();
                P1OK2.ImageLocation = Path.GetFullPath(oranjekaart2P1.image);
                BalanceP1 -= 10;
                KoopP2.Enabled = false;
                BalP1.Text = "Balance: " + BalanceP1;
                P1Kaarten += 1;
                WinChecker();
            }
        }

        private void KoopP3_Click(object sender, EventArgs e)
        {
            if (BalanceP1 >= 16)
            {
                OranjeKaart oranjekaart3P1 = OranjeKaarten.GetAndRemoveOranjeKaart3();
                P1OK3.ImageLocation = Path.GetFullPath(oranjekaart3P1.image);
                BalanceP1 -= 16;
                KoopP3.Enabled = false;
                BalP1.Text = "Balance: " + BalanceP1;
                P1Kaarten += 1;
                WinChecker();
            }
        }

        private void KoopP4_Click(object sender, EventArgs e)
        {
            if (BalanceP1 >= 22)
            {
                OranjeKaart oranjekaart4P1 = OranjeKaarten.GetAndRemoveOranjeKaart4();
                P1OK4.ImageLocation = Path.GetFullPath(oranjekaart4P1.image);
                BalanceP1 -= 22;
                KoopP4.Enabled = false;
                BalP1.Text = "Balance: " + BalanceP1;
                P1Kaarten += 1;
                WinChecker();
            }
        }


        //Koop knoppen P2
        private void KoopP5_Click(object sender, EventArgs e)
        {
            if (BalanceP2 >= 4)
            {
                OranjeKaart oranjekaart1P2 = OranjeKaarten.GetAndRemoveOranjeKaart();
                P2OK1.ImageLocation = Path.GetFullPath(oranjekaart1P2.image);
                BalanceP2 -= 4;
                KoopP5.Enabled = false;
                BalP2.Text = "Balance: " + BalanceP2;
                P2Kaarten += 1;
                WinChecker();
            }
        }

        private void KoopP6_Click(object sender, EventArgs e)
        {
            if (BalanceP2 >= 10)
            {
                OranjeKaart oranjekaart2P2 = OranjeKaarten.GetAndRemoveOranjeKaart2();
                P2OK2.ImageLocation = Path.GetFullPath(oranjekaart2P2.image);
                BalanceP2 -= 10;
                KoopP6.Enabled = false;
                BalP2.Text = "Balance: " + BalanceP2;
                P2Kaarten += 1;
                WinChecker();
            }
        }

        private void KoopP7_Click(object sender, EventArgs e)
        {
            if (BalanceP2 >= 16)
            {
                OranjeKaart oranjekaart3P2 = OranjeKaarten.GetAndRemoveOranjeKaart3();
                P2OK3.ImageLocation = Path.GetFullPath(oranjekaart3P2.image);
                BalanceP2 -= 16;
                KoopP7.Enabled = false;
                BalP2.Text = "Balance: " + BalanceP2;
                P2Kaarten += 1;
                WinChecker();
            }
        }

        private void KoopP8_Click(object sender, EventArgs e)
        {
            if (BalanceP2 >= 22)
            { 
                OranjeKaart oranjekaart4P2 = OranjeKaarten.GetAndRemoveOranjeKaart4();
                P2OK4.ImageLocation = Path.GetFullPath(oranjekaart4P2.image);
                BalanceP2 -= 22;
                KoopP8.Enabled = false;
                BalP2.Text = "Balance: " + BalanceP2;
                P2Kaarten += 1;
                WinChecker();
            }
        }


        //Koop knoppen P3
        private void KoopP9_Click(object sender, EventArgs e)
        {
            if (BalanceP3 >= 4)
            {
                OranjeKaart oranjekaart1P3 = OranjeKaarten.GetAndRemoveOranjeKaart();
                P3OK1.ImageLocation = Path.GetFullPath(oranjekaart1P3.image);
                BalanceP3 -= 4;
                KoopP9.Enabled = false;
                BalP3.Text = "Balance: " + BalanceP3;
                P3Kaarten += 1;
                WinChecker();
            }
        }

        private void KoopP10_Click(object sender, EventArgs e)
        {
            if (BalanceP3 >= 10)
            {
                OranjeKaart oranjekaart2P3 = OranjeKaarten.GetAndRemoveOranjeKaart2();
                P3OK2.ImageLocation = Path.GetFullPath(oranjekaart2P3.image);
                BalanceP3 -= 10;
                KoopP10.Enabled = false;
                BalP3.Text = "Balance: " + BalanceP3;
                P3Kaarten += 1;
                WinChecker();
            }
        }

        private void KoopP11_Click(object sender, EventArgs e)
        {
            if (BalanceP3 >= 16)
            {
                OranjeKaart oranjekaart3P3 = OranjeKaarten.GetAndRemoveOranjeKaart3();
                P3OK3.ImageLocation = Path.GetFullPath(oranjekaart3P3.image);
                BalanceP3 -= 16;
                KoopP11.Enabled = false;
                BalP3.Text = "Balance: " + BalanceP3;
                P3Kaarten += 1;
                WinChecker();
            }
        }

        private void KoopP12_Click(object sender, EventArgs e)
        {
            if (BalanceP3 >= 22)
            {
                OranjeKaart oranjekaart4P3 = OranjeKaarten.GetAndRemoveOranjeKaart4();
                P3OK4.ImageLocation = Path.GetFullPath(oranjekaart4P3.image);
                BalanceP3 -= 22;
                KoopP12.Enabled = false;
                BalP3.Text = "Balance: " + BalanceP3;
                P3Kaarten += 1;
                WinChecker();
            }
        }


        //Koop knoppen P4
        private void KoopP13_Click(object sender, EventArgs e)
        {
            if (BalanceP4 >= 4)
            {
                OranjeKaart oranjekaart1P4 = OranjeKaarten.GetAndRemoveOranjeKaart();
                P4OK1.ImageLocation = Path.GetFullPath(oranjekaart1P4.image);
                BalanceP4 -= 4;
                KoopP13.Enabled = false;
                BalP4.Text = "Balance: " + BalanceP4;
                P4Kaarten += 1;
                WinChecker();
            }
        }

        private void KoopP14_Click(object sender, EventArgs e)
        {
            if (BalanceP4 >= 10)
            {
                OranjeKaart oranjekaart2P4 = OranjeKaarten.GetAndRemoveOranjeKaart2();
                P4OK2.ImageLocation = Path.GetFullPath(oranjekaart2P4.image);
                BalanceP4 -= 10;
                KoopP14.Enabled = false;
                BalP4.Text = "Balance: " + BalanceP4;
                P4Kaarten += 1;
                WinChecker();
            }
        }

        private void KoopP15_Click(object sender, EventArgs e)
        {
            if (BalanceP4 >= 16)
            {
                OranjeKaart oranjekaart3P4 = OranjeKaarten.GetAndRemoveOranjeKaart3();
                P4OK3.ImageLocation = Path.GetFullPath(oranjekaart3P4.image);
                BalanceP4 -= 16;
                KoopP15.Enabled = false;
                BalP4.Text = "Balance: " + BalanceP4;
                P4Kaarten += 1;
                WinChecker();
            }
        }

        private void KoopP16_Click(object sender, EventArgs e)
        {
            if (BalanceP3 >= 22)
            {
                OranjeKaart oranjekaart4P4 = OranjeKaarten.GetAndRemoveOranjeKaart4();
                P4OK4.ImageLocation = Path.GetFullPath(oranjekaart4P4.image);
                BalanceP4 -= 22;
                KoopP16.Enabled = false;
                BalP4.Text = "Balance: " + BalanceP4;
                P4Kaarten += 1;
                WinChecker();
            }
        }


        public void KoopKnoppenUit()
        {
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
        public void LabelBlank()
        {
            WheatFieldL.Text = "";
            RanchL.Text = "";
            MineL.Text = "";
            ForestL.Text = "";
            AppleOrchardL.Text = "";
            BakeryL.Text = "";
            ConvenienceStoreL.Text = "";
            CheeseFactoryL.Text = "";
            FurnitureFactoryL.Text = "";
            FruitAndVegetableMarketL.Text = "";
            CafeL.Text = "";
            FamilyRestaurantL.Text = "";
            BusinessCenterL.Text = "";
            TvStationL.Text = "";
            StadiumL.Text = "";
        }
        public void CheckEffecten(int uitkomst)
        {
            for (int speler = 0 ; speler < AantalSpelers; speler++)
            {

            }
        }
    }
}


