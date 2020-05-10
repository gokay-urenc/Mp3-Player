using System;
using System.Windows.Forms;

namespace MyMp3Player
{
    public partial class Form1 : Form
    {
        private Mp3Player mp3Player = new Mp3Player();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "MP3 Files|*.mp3|MP4 Files|*.mp4|WAV Files|*.wav";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    mp3Player.open(ofd.FileName);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mp3Player.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mp3Player.stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}