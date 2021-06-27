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
    public partial class About : Form
    {
        
        public About()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            Form1 F1 = new Form1();
            F1.Show();
            About A1 = new About();
            A1.Hide();
            this.Hide();
        }

        private void About_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Mute_Click(object sender, EventArgs e)
        {
   
        }

        private void Start_Click(object sender, EventArgs e)
        {
            
            
            

        }
    }
}
