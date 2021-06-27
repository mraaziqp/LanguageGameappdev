using System;
using System.Windows.Forms;
using WMPLib;
using System.Media;

namespace Language_Game
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer bgMusic = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            bgMusic.SoundLocation = "quizaudio.wav";
            

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            bgMusic.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Languages L1 = new Languages();
            Form1 F1 = new Form1();
            L1.Show();
            F1.Hide();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About A1 = new About();
            Form1 F1 = new Form1();
            A1.Show();
            F1.Hide();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bgMusic.Play();
            Mute.Visible = true;
            Start.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bgMusic.Stop();
            Mute.Visible = false;
            Start.Visible = true;

        }
    }
}
