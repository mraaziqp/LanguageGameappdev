using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Language_Game
{
    public partial class Languages : Form
    {
        public Languages()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnglishLevels EL = new EnglishLevels();
            EL.Show();
            Languages L1 = new Languages();
            L1.Hide();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AfrikaansLevels AL = new AfrikaansLevels();
            AL.Show();
            Languages L1 = new Languages();
            L1.Hide();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 F12 = new Form1();
            F12.Show();
            this.Hide();
        }

        private void Mute_Click(object sender, EventArgs e)
        {

        }
    }
}
