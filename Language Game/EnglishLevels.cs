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
    public partial class EnglishLevels : Form
    {
        public EnglishLevels()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnglishLevel1 EL1 = new EnglishLevel1();
            EL1.Show();
            EnglishLevels EL = new EnglishLevels();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnglishLevel2 EL2 = new EnglishLevel2();
            EL2.Show();
            EnglishLevels EL = new EnglishLevels();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Languages F12 = new Languages();
            F12.Show();
            this.Hide();
        }
    }
}
