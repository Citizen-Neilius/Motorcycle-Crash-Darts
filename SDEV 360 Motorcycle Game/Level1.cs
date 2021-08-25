using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Neil Little -  SDEV 360 - 
// Final Project: 
// 01 May 2020

namespace SDEV_360_Motorcycle_Game
{

    public partial class Form1 : Form
    {
        bool flying = false;
        bool clickReleased = false;
        protected bool mousedown = false;        
        protected bool r = true;
        string username;
        int motionPicX = 2;
        int fallingSpeed = 2;
        //int speedTinterval = 0;
        MotorCycle motorCycle;
        int score;
        bool stuck = false; // variable for stuck in the target.


        public Form1(string playername, MotorCycle motorCycle)
        {
            InitializeComponent();
            this.motorCycle = motorCycle;
            username = playername;

           

            //pictureBoxEx1.Location = new Point(200,370);
            //pictureBoxEx2.Location = new Point(480,270);
            //pictureBoxEx3.Location = new Point(760,370);
            //pictureBoxEx4.Location = new Point(1040,270);
            //lblGameOver.Visible = false;
            //lblYouWin.Visible = false;

        }
        

        private void timer1_Tick(object sender, EventArgs e)  // this timer controls how fast the motorcycle is going before the crash. 
        {
            if (pictureBoxBiker.Location.X > 1250)  // this is the crash point.
            {
                pictureBoxBiker.Image = Properties.Resources.crashed__5;
                Acceleration.Stop();
                timerSpeed.Stop();
                pictureBoxFlying.Visible = true;
                flying = true;                                 // flying is now true since he is launched off of the motorcycle.
                timerFlyingImagemover.Start();
                timerControlFlying.Start();
                motionPicX = 7;

            }

            { 
                if (motionPicX > 10 && mousedown == false && pictureBoxBiker.Image != Properties.Resources.crashed__5)
                {
                    motionPicX--;  // slows the bike when acceleratior releases.
                 }


            
                if (motionPicX <= 1)
                {
                    timerSpeed.Stop();
                    
                }
                if (mousedown == true && motionPicX<8 && pictureBoxBiker.Image != Properties.Resources.crashed__5) 
                {
                    
                    motionPicX++;  // seeds bike up
                    timerSpeed.Start();
                }
                if (mousedown == false && motionPicX > 0 && pictureBoxBiker.Image != Properties.Resources.crashed__5)
                {
                    motionPicX--;
                    timerSpeed.Start();
                }
                

            }


        }

        private void buttonGo_Click(object sender, EventArgs e)  // This button starts the acceleration timer and sets the engine interval to 50 (fast)
        {
            
        }

        private void buttonGo_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void buttonGo_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void buttonStop_Click(object sender, EventArgs e)// this button stops the acceleration timer and changes the engine interval to an idol (100, slow)
        {

        }

        private void timerAnimate_Tick(object sender, EventArgs e)  //This timer animates the motorcycle's engine vibrations
        {
            if (flying == true)
            {
                if (mousedown == false)
                {


                    if (r == false)
                    {
                        pictureBoxFlying.Image = Properties.Resources.flying02;
                        //the images are loaded as resources
                        r = true;
                    }
                    else
                    {
                        pictureBoxFlying.Image = Properties.Resources.flying01;
                        r = false;
                    }
                }


                if ( mousedown == true)

                    if (r == false)
                    {
                        pictureBoxFlying.Image = Properties.Resources.rippin01;
                        //the images are loaded as resources
                        r = true;
                    }
                    else
                    {
                        pictureBoxFlying.Image = Properties.Resources.rippin02;
                        r = false;
                    }
            }
            else if( stuck == true)
            {
                if (r == false)
                {
                    pictureBoxFlying.Image = Properties.Resources.Stuck01;
                    //the images are loaded as resources
                    r = true;
                }
                else
                {
                    pictureBoxFlying.Image = Properties.Resources.Stuck02;
                    r = false;
                }
            }
            else

            {
                if (r == false)
                {
                    pictureBoxBiker.Image = Properties.Resources.sprite_bike__5_01;
                    //the images are loaded as resources
                    r = true;
                }
                else
                {
                    pictureBoxBiker.Image = Properties.Resources.sprite_bike__5_02;
                    r = false;
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            //if (pictureBoxBiker.Location.Y < 300) 
            //{
            //    pictureBoxBiker.Location = new Point(pictureBoxBiker.Location.X, pictureBoxBiker.Location.Y + 10);
            //}
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            //if (pictureBoxBiker.Location.Y > 200)
            //{
            //    pictureBoxBiker.Location = new Point(pictureBoxBiker.Location.X, pictureBoxBiker.Location.Y - 10);
            //}
        }

        private void pictureBoxEx1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            if (pictureBoxFlying.Visible == false)
            {
                Acceleration.Start();
            }
         
            //timerSpeed.Start();

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
            if (flying == true)
            {
                clickReleased = true;
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormTitleScreen.ActiveForm.Hide();
            Acceleration.Stop();
            timerSpeed.Stop();
            timerFlyingImagemover.Stop();
            timerControlFlying.Stop();
            
            //FormTitleScreen titleScreen = new FormTitleScreen();
            //titleScreen.Show();
            //titleScreen.BringToFront();
            //MotorCycle Kawasaki = new MotorCycle(5, 175, 700);
            //MotorCycle Harley = new MotorCycle(2, 120, 1000);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           

        }

        private void timerSpeed_Tick(object sender, EventArgs e)
        {
            pictureBoxBiker.Location = new Point(pictureBoxBiker.Location.X + motionPicX, pictureBoxBiker.Location.Y);
        }

        private void timerFlyingImagemover_Tick(object sender, EventArgs e)    // Controls flying guy's movement.
        {
            if (pictureBoxFlying.Location.X > 1200 || pictureBoxFlying.Location.Y <300 || pictureBoxFlying.Location.Y > 850)  //target out of bounds
            {
                timerFlyingImagemover.Stop();
                timerControlFlying.Stop();
                stuck = true;
                flying = false;
                score = 100 - Math.Abs(pictureBoxFlying.Location.Y - 630);
                labelScore.Text = Convert.ToString(score);
                timerSpeed.Enabled = false;
                buttonEndGame.Visible = true;

                //630 = 100
                //500 and 760 = 0

            }
                
            pictureBoxFlying.Location = new Point(pictureBoxFlying.Location.X + motionPicX, pictureBoxFlying.Location.Y + fallingSpeed);
        }

        private void timerControlFlying_Tick(object sender, EventArgs e)  // Timer controls the rate of fall when flying.  
        {
            if (flying == true)
            {


                timerSpeed.Stop();
                if (mousedown == false)
                {
                    fallingSpeed++;
                }
                if (mousedown == true)
                {
                    fallingSpeed--;
                }
            }
            score = pictureBoxFlying.Location.Y;
            labelScore.Text = Convert.ToString(score);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEndGame_Click(object sender, EventArgs e)
        {
            FormTitleScreen formTitleScreen = new FormTitleScreen();
            formTitleScreen.EndGame(score);   // Ends the game
            formTitleScreen.Show();
            Close();
        }
        // Unused key use reference.  Probably will not be used.
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)  
        //{
        //    ////capture up arrow key
        //    //if (keyData == Keys.Up)
        //    //{
        //    //    btnUp.PerformClick();
        //    //    return true;
        //    //}
        //    ////capture down arrow key
        //    //if (keyData == Keys.Down)
        //    //{
        //    //    btnDown.PerformClick();
        //    //    return true;
        //    //}
        //    ////capture left arrow key
        //    //if (keyData == Keys.Left)
        //    //{
        //    //    buttonStop.PerformClick();
        //    //    return true;
        //    //}
        //    ////capture right arrow key
        //    //if (keyData == Keys.Right)
        //    //{
        //    //    buttonGo.PerformClick();
        //    //    return true;
        //    //}
        //    //return base.ProcessCmdKey(ref msg, keyData);
        //}
    }
}
