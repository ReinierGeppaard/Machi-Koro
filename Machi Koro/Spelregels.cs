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
    public partial class Spelregels : Form
    {
        string[] Images;
        int current = 0;
        public Spelregels()
        {
            InitializeComponent();
            Images = new string[]
            {
                "../../Resources/Spelregels1.png", "../../Resources/Spelregels2.png", "../../Resources/Spelregels3.png", "../../Resources/Spelregels4.png"
            };
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            current = (current - 1 + 4) % 4;
            PicBox.ImageLocation = Path.GetFullPath(Images[current]);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            current = (current + 1) % 4;
            PicBox.ImageLocation = Path.GetFullPath(Images[current]);
        }
    }
}
