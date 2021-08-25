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

    public partial class FormLevel2 : Form   // Second "level" with an obstacle
    {
        bool flying = false;   // variable for after crash  
        bool failHit= false;    // if bike crashes after 
        bool clickReleased = false;  // mouse click variable    
        protected bool mousedown = false;        //mouse variable
        protected bool r = true;            //variable for animation
        string username;                    
        int motionPicX = 2;                 // motionPicX is speed
        int fallingSpeed = 2;               // falling speed
        //int speedTinterval = 0;
        MotorCycle motorCycle;              // creating a class motorcycle 
        int score;
        bool stuck = false; // variable for stuck in the target.


        public FormLevel2(string playername, MotorCycle motorCycle)  //recieves motorcycle data from title form upon load
        {
            InitializeComponent();   
            this.motorCycle = motorCycle;
            username = playername;
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


            
                if (motionPicX <= 1)  // If the bike is no longer moving, stop the timer.
                {
                    timerSpeed.Stop();
                    
                }
                if (mousedown == true && motionPicX<8 && pictureBoxBiker.Image != Properties.Resources.crashed__5) 
                {
                    
                    motionPicX++;  // speeds bike up
                    timerSpeed.Start();
                }
                if (mousedown == false && motionPicX > 0 && pictureBoxBiker.Image != Properties.Resources.crashed__5)
                {
                    motionPicX--;
                    timerSpeed.Start();  // slows bike down when click is relasesd.
                }
                

            }


        }

        private void buttonGo_Click(object sender, EventArgs e)  //
        {
            
        }

        private void buttonGo_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void buttonGo_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void buttonStop_Click(object sender, EventArgs e)// 
        {

        }

        private void timerAnimate_Tick(object sender, EventArgs e)  //This timer animates the motorcycle's engine vibrations and flying animation
        {
            if (flying == true)   // different animations for flying
            {
                if (mousedown == false)  // free falling images
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


                if ( mousedown == true)  // launch images

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
            else if( stuck == true)  // images for stuck in a target or obstacle
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

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxEx1_Click(object sender, EventArgs e)
        {

        }

        private void FormLevel2_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;  // changes the boolean value of mousedown to true and starts the bike accelerator.
            if (pictureBoxFlying.Visible == false)
            {
                Acceleration.Start();
            }
         
            //timerSpeed.Start();

        }

        private void FormLevel2_MouseUp(object sender, MouseEventArgs e)  //switches to mouse up mode.
        {
            mousedown = false;
            if (flying == true)
            {
                clickReleased = true;
            }
            

        }

        private void FormLevel2_Load(object sender, EventArgs e)  //loading hides title screen and controls timers
        {
            FormTitleScreen.ActiveForm.Hide();
            Acceleration.Stop();
            timerSpeed.Stop();
            timerFlyingImagemover.Stop();
            timerControlFlying.Stop();
        }

        private void FormLevel2_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void FormLevel2_FormClosed(object sender, FormClosedEventArgs e)
        {
           

        }

        private void timerSpeed_Tick(object sender, EventArgs e)
            // timer that moves the bike location
        {
            pictureBoxBiker.Location = new Point(pictureBoxBiker.Location.X + motionPicX, pictureBoxBiker.Location.Y);

        }
        public void Collision()  //method to be called upon hitting a target or colliding
        {
            timerFlyingImagemover.Stop();
            timerControlFlying.Stop();
            stuck = true;
            flying = false;
            timerSpeed.Enabled = false;
            buttonEndGame.Visible = true;
            if (failHit == false) // if bicycle hits the target
            {
                score = 100 - Math.Abs(pictureBoxFlying.Location.Y - 630);
                labelScore.Text = Convert.ToString(score);
            }    
            else
            {
                score = 0;
                labelScore.Text = Convert.ToString(score);
            }

    
        }
        private void timerFlyingImagemover_Tick(object sender, EventArgs e)    // Controls flying guy's movement.
        {
            if (pictureBoxFlying.Location.X > 1200 || pictureBoxFlying.Location.Y <300 || pictureBoxFlying.Location.Y > 850)  // events that will stop biker
            {
                Collision();
                if (pictureBoxFlying.Location.X < 1200)  // if the bike is out of bounds, score is zero.
                {
                    score = 0;
                    labelScore.Text = Convert.ToString(score);
                    buttonEndGame.Text = "Out of bounds! Press to update score!";
                }

                //630 = 100
                //500 and 760 = 0
            }
            if (pictureBoxFlying.Location.X > pictureBoxObstacle.Location.X - 40 && pictureBoxFlying.Location.Y > pictureBoxObstacle.Location.Y-40)
            {
                if ((pictureBoxFlying.Location.X < pictureBoxObstacle.Location.X)) // collision with the obstacle
                    {
                    failHit = true;
                    Collision();
                    
                }
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
            //score = pictureBoxFlying.Location.Y;
            //labelScore.Text = Convert.ToString(score);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEndGame_Click(object sender, EventArgs e)  // closes form and sends score to title screen
        {
            FormTitleScreen formTitleScreen = new FormTitleScreen();
            formTitleScreen.EndGame(score);   // Ends the game
            formTitleScreen.Show();
            Close();
        }

        private void FormLevel2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
