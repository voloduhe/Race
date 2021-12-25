using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RaceProject
{
    class Moving
    {
        private Vehicle Vehicle;
        private int Time;
        private double DistanceRace;
        Random rand = new Random();


        public Moving(Vehicle vehicle, int time, double distance)
        {
            this.Vehicle = vehicle;
            this.Time = time;
            this.DistanceRace = distance;
        }
        public void GoThread()
        {
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
