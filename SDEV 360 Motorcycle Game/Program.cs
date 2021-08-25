using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDEV_360_Motorcycle_Game


// Neil Little -  SDEV 360 - 
// Final Project: 
// 01 May 2020

{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new FormTitleScreen());
           
        }
    }

    public  class Collision
    {
        public bool Crashed(PictureBox obstacle, PictureBox rider)
        {
            int obstacleTop = obstacle.Location.Y + 5;
            int obstacleBottom = obstacle.Location.Y + obstacle.Height + 5;
            int obstacleFront = obstacle.Location.X;
            int obstacleBack = obstacle.Location.X + obstacle.Width;
            

            int riderTop = rider.Location.Y + 20;
            int riderBottom = rider.Location.Y + rider.Height - 20;
            int riderFront = rider.Location.X + rider.Width - 50;
            int riderBack = rider.Location.X + 30;

            bool isUpper = false;
            bool isLower = false;

            if(obstacleTop == 275)
            {
                isUpper = true;
                isLower = false;
            }

            if (obstacleTop == 375)
            {
                isUpper = false;
                isLower = true;
            }


            if ((riderFront > obstacleFront && riderBack < obstacleBack) &&
                ((riderBottom > obstacleTop && isLower) || (riderBottom < obstacleBottom && isUpper)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
