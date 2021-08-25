using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDEV_360_Motorcycle_Game
{


    // Neil Little -  SDEV 360 - 
    // Final Project: 
    // 01 May 2020

    public class MotorCycle
    {
        int accelerationSpeed;
        int maxspeed;
        int weight;
        //int driver;

        public MotorCycle(int accelerationSpeed, int maxspeed, int weight)
        {
            this.AccelerationSpeed = accelerationSpeed;
            //this.driver = driver;
            this.Maxspeed = maxspeed;
            this.Weight = weight;
        }

        public int AccelerationSpeed { get => accelerationSpeed; set => accelerationSpeed = value; }
        public int Maxspeed { get => maxspeed; set => maxspeed = value; }
        public int Weight { get => weight; set => weight = value; }
    }
}
