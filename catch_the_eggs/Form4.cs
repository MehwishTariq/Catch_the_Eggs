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
    public partial class Form4 : Form
    {
        
        SoundPlayer s1 = new SoundPlayer("button-3.wav");
        SoundPlayer _sound = new SoundPlayer("Lynn Music Boulangerie   Gaming Background Music HD.wav");
        public Form4()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s1.Play();
            Form2 f = new Form2();
            f.Show();            
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            _sound.Play();
        }
    }
}
