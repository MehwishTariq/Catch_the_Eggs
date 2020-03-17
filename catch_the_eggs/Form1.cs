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
    public partial class Form1 : Form
    {
        bool goleft;                    //to check if the user can move to the left or not
        bool goright;                   //to check if the user can move to the right or not
        int speed = 5;                  //egg falling speed(default set to 8)
        int score = 0;                  //default score set to zero
        int missed = 0;                 //number of eggs missed(default set to zero)
        Random rndX = new Random();              //to generate a random x location
        Random rndY = new Random();              //to generate a random y location
        PictureBox splash = new PictureBox();    //creates a new picture box for splashed egg DYNAMICALLY 
        SoundPlayer _sound = new SoundPlayer("Lynn Music Boulangerie   Gaming Background Music HD.wav");
        SoundPlayer _sound1 = new SoundPlayer("244745__reitanna__egg-crack19.wav");
       
        public Form1()
        { 
            InitializeComponent();
            chicken.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.BackColor = System.Drawing.Color.Transparent; 
            Bomb.BackColor = System.Drawing.Color.Transparent;
            
        }

        private void keyisdown(object sender, KeyEventArgs e)   //invoked when any key is pressed
        {
            if( e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)     //invoked when the pressed key is released
        {
            if(e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void gameTick(object sender, EventArgs e)
        {
          
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label1.Text = "EggsCaught:" + score;
            label2.Text = "Eggs Missed:" + missed;
            if (goleft == true && chicken.Left > 0)
            {
                chicken.Left -= 12;
                chicken.Image = Properties.Resources.chicken_normal2;
            }
            if (goright == true && chicken.Left + chicken.Width < 628)
            {
                chicken.Left += 12;
                chicken.Image = Properties.Resources.chicken_normal;
            }
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && (string)X.Tag == "Bomb")
                {
                    X.Top += speed;
                    if (X.Top + X.Height > this.Height)
                    {
                        X.Top = rndY.Next(80, 300);
                        X.Left = rndX.Next(5, 628 - X.Width);
                    }
                        
                    if (X.Bounds.IntersectsWith(chicken.Bounds))
                    {
                        gameTimer.Stop();
                        Form3 f3 = new Form3();
                        f3.Show();
                        this.Hide();
                        MessageBox.Show("Your Final Score is:" + score);
                        this.Close();
                    }
                }


                if (X is PictureBox && (string)X.Tag == "Eggs")
                {
                    X.Top += speed;
                    if (X.Top + X.Height > this.Height)
                    {
                        splash.Image = Properties.Resources.splash;
                        splash.Location = X.Location;
                        splash.Height = 59;
                        splash.Width = 60;
                        splash.BackColor = System.Drawing.Color.Transparent;
                        this.Controls.Add(splash);
                        _sound1.Play();
                        _sound.Play();
                        X.Top = rndY.Next(80, 300);
                        X.Left = rndX.Next(5, 628 - X.Width);
                        missed++;
                        chicken.Image = Properties.Resources.chicken_hurt;
                       
                    }
                    if (X.Bounds.IntersectsWith(chicken.Bounds))
                    {
                        X.Top = rndY.Next(100, 300) * -1;
                        X.Left = rndX.Next(5, 628 - X.Width);
                        score++;
                    }

                    if (score >= 10)
                    {
                        speed = 8; 
                    }
                    
                    if (missed > 6)
                    {
                        gameTimer.Stop();                                   
                        Form5 f2 = new Form5();
                        f2.Show();
                        this.Hide();
                        MessageBox.Show("Your Final Score is:" + score);
                        this.Close();

                    }
                }
            }
                
          }

         private void Form1_Load(object sender, EventArgs e)
        {            
            _sound.Play();
        }
         
       private void Bomb_Click(object sender, EventArgs e)      
        {

        }

        private void chicken_Click(object sender, EventArgs e)
        {

        }
    }
}
