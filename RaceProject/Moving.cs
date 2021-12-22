﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RaceProject
{
    class Moving
    {
        //ДОБАВИТЬ МНОГОПОТОЧНОСТЬ
        private Vehicle Vehicle;
        private DateTime StartTime;
        private double DistanceRace;
        Random rand = new Random();

        public Moving(Vehicle vehicle, int time, double distance)
        {
            this.Vehicle = vehicle;
            this.StartTime = new DateTime(time);
            this.DistanceRace = distance;
        }
        public void Go()
        {
            while (!this.StartTime.Equals(new DateTime()))
            { 
                
            }
            int chance = this.Vehicle.getPiercingTireChance();

            while(this.DistanceRace > this.Vehicle.getCurrentDistance())
            {
                if (chance <= rand.Next(100))
                {
                    this.Vehicle.nextMove(this.DistanceRace, 0.1);
                }
                else 
                {
                    this.Vehicle.nextPierce();
                }
            }
        }
    }
}