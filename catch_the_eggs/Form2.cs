using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace catch_the_eggs
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SoundPlayer Sound = new SoundPlayer("button-3.wav");
        SoundPlayer _sound = new SoundPlayer("Lynn Music Boulangerie   Gaming Background Music HD.wav");
        private void button1_Click_1(object sender, EventArgs e)
        {
            Sound.Play();
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "EGGILICIOUS";
            label1.BackColor= System.Drawing.Color.Transparent;
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.BackColor = System.Drawing.Color.Transparent;
            _sound.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sound.Play();
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sound.Play();
            this.Close();
            
        }
    }
}
