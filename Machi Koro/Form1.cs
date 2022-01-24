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
        Dobbel dobbel = new Dobbel();
        Kaart OranjeKaarten = new Kaart();
        Kaart OranjeKaartenB = new Kaart();
        int BalanceP1 = 0;

        List<PictureBox> DobbelsteenPicturebox = new List<PictureBox>();
        List<PictureBox> OranjeKaartPicturebox = new List<PictureBox>();



        public Form1()
        {
            InitializeComponent();
            DobbelsteenPicturebox.Add(Dobbel1P);
            DobbelsteenPicturebox.Add(Dobbel2P);
            Dobbel1.Enabled = false;
            Dobbel2.Enabled = false;
            KoopP1.Enabled = false;
            KoopP2.Enabled = false;
            KoopP3.Enabled = false;
            KoopP4.Enabled = false;
            BalanceP1 = 0;
            BalP1.Text = "Balance: " + BalanceP1;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Dobbel1_Click(object sender, EventArgs e)
        {
            Dobbelstenen.RandomNummer();
            Dobbelstenen.Dobbelen();
            Dobbel dobbel = Dobbelstenen.GetAndRemoveDobbel();
            Dobbel1P.ImageLocation = Path.GetFullPath(dobbel.image);
        }

        private void Dobbel2_Click(object sender, EventArgs e)
        {
            Dobbelstenen.RandomNummer();
            Dobbelstenen.Dobbelen();
            Dobbel dobbel = Dobbelstenen.GetAndRemoveDobbel();
            Dobbel1P.ImageLocation = Path.GetFullPath(dobbel.image);
            Dobbelstenen.RandomNummer();
            Dobbelstenen.Dobbelen();
            Dobbel dubbel = Dobbelstenen.GetAndRemoveDobbel();
            Dobbel2P.ImageLocation = Path.GetFullPath(dubbel.image);
        }

        private void StartSpel_Click(object sender, EventArgs e)
        {
            StartSpel.Enabled = false;
            Dobbel1.Enabled = true;
            Dobbel2.Enabled = true;
            KoopP1.Enabled = true;
            KoopP2.Enabled = true;
            KoopP3.Enabled = true;
            KoopP4.Enabled = true;
            BalanceP1 = 100;
            BalP1.Text = "Balance: " + BalanceP1;

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

        private void KoopP1_Click(object sender, EventArgs e)
        {
            if (BalanceP1 >= 4)
            {
                OranjeKaartenB.RemoveOranjeKaartB();
                OranjeKaart oranjekaart1P1 = OranjeKaarten.GetAndRemoveOranjeKaart();
                P1OK1.ImageLocation = Path.GetFullPath(oranjekaart1P1.image);
                BalanceP1 -= 4;
                KoopP1.Enabled = false;
                BalP1.Text = "Balance: " + BalanceP1;
            }
        }

        private void KoopP2_Click(object sender, EventArgs e)
        {
            if (BalanceP1 >= 10)
            {
                OranjeKaartenB.RemoveOranjeKaartB();
                OranjeKaart oranjekaart2P1 = OranjeKaarten.GetAndRemoveOranjeKaart2();
                P1OK2.ImageLocation = Path.GetFullPath(oranjekaart2P1.image);
                BalanceP1 -= 10;
                KoopP2.Enabled = false;
                BalP1.Text = "Balance: " + BalanceP1;
            }
        }

        private void KoopP3_Click(object sender, EventArgs e)
        {
            if (BalanceP1 >= 16)
            {
                OranjeKaartenB.RemoveOranjeKaartB();
                OranjeKaart oranjekaart3P1 = OranjeKaarten.GetAndRemoveOranjeKaart3();
                P1OK3.ImageLocation = Path.GetFullPath(oranjekaart3P1.image);
                BalanceP1 -= 16;
                KoopP3.Enabled = false;
                BalP1.Text = "Balance: " + BalanceP1;
            }
        }

        private void KoopP4_Click(object sender, EventArgs e)
        {
            if (BalanceP1 >= 22)
            {
                OranjeKaartenB.RemoveOranjeKaartB();
                OranjeKaart oranjekaart4P1 = OranjeKaarten.GetAndRemoveOranjeKaart4();
                P1OK4.ImageLocation = Path.GetFullPath(oranjekaart4P1.image);
                BalanceP1 -= 22;
                KoopP4.Enabled = false;
                BalP1.Text = "Balance: " + BalanceP1;
            }
        }
    }
}


