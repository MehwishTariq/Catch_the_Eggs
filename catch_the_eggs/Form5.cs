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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SoundPlayer s1 = new SoundPlayer("button-3.wav");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s1.Play();
            Form2 f = new Form2();
            f.Show();
            this.Close();
        }
    }
}
