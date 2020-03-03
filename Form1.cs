using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallBounce
{
    public partial class BallWall : Form
    {
        int scores = 0;
        public BallWall()
        {
            InitializeComponent();

            //vert.Interval = 10;
            //horizontal.Interval = 10;
            //vert.Start();
            //horizontal.Start();
            string path = @"C:\Users\highscore.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine("0");
                tw.Close();
            }

            StreamReader reader = new StreamReader(path);
            string content = reader.ReadLine();
            lbHighScore.Text = "High Score: " + content;
            reader.Close();
        }

        
        int speed = 2;
        // int sliderSpeed = -10;
        bool gameOver = false;
        int hdir = +1;
        private void horizontal_Tick(object sender, EventArgs e)
        {
           // Scores();
            if (ball.Left < 0)
            {
                hdir = +1;
            }
            else if (ball.Left > (this.Width - ball.Width))
            {
                hdir = -1;
            }

            ball.Left += (hdir*speed);
        }

        int vdir = +1;
        private void vertical_Tick(object sender, EventArgs e)
        {
            
            if (ball.Top < 0)
            {
                vdir = +1;
            }
            else if (ball.Top > (this.Height - ball.Height - strock.Height))
            {
                //ball.Left < strock.Left || ((ball.Left + ball.Width) > (strock.Left + strock.Width))
                if (!ball.Bounds.IntersectsWith(strock.Bounds))
                {

                    vertical.Enabled = horizontal.Enabled = timer1.Enabled = timerscore.Enabled = false;
                    gameOver = true;
                    lbPause.Text = "Game Over";
                    lbPause.ForeColor = Color.Red;
                    panelPaused.Visible = true;


                }
                else
                {
                    speed += 1;
                }
                vdir = -1;
            }
            
            ball.Top += (vdir*speed);

            
        }

        void Scores()
        {
            
                scores = scores + 1;
                lblScores.Text = "Scores: " + scores;
            
            //scores = scores + 2;
            //    lblScores.Text = "Scores: "+scores;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        bool _left = false, _right = false;

        public Color Red { get; private set; }

        private void BallWall_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Right)
            {
                _right = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                _left = true;
            }
            else if (e.KeyCode == Keys.Space)
            {
                vertical.Enabled = horizontal.Enabled = timer1.Enabled = timerscore.Enabled = false;
                panelPaused.Visible = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                vertical.Enabled = horizontal.Enabled = timer1.Enabled = timerscore.Enabled = true;
                panelPaused.Visible = false;
                if (gameOver == true)
                {
                    Application.Restart();
                    gameOver = false;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Scores();
            if (_right && strock.Left < (this.Width - strock.Width))
            {
                strock.Left = strock.Left + 50;
            }
            else if (_left && strock.Left > 0)
            {
                strock.Left = strock.Left - 50;
            }
        }

        private void BallWall_Load(object sender, EventArgs e)
        {
           
               
            
        }

        private void timerscore_Tick(object sender, EventArgs e)
        {
 Scores();
        }

        private void BallWall_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                _right = _left = false; // disable all
            }
        }
    }
}
