using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RaceProject
{
    abstract public class Vehicle
    {
        private int Speed;
        private int PiercingTireChance;
        private double RoundTime = 0;
        private double CurrentDistance = 0;

        Random rand = new Random();

        public double getCurrentDistance()
        {
            return this.CurrentDistance;
        }
        ////////////////
        public void setLapTime(double time)
        {
            this.RoundTime = time;
        }
        public double getRoundTime()
        {
            return this.RoundTime;   
        }
        ////////////////
        public void setSpeed(int speed)
        {
            this.Speed = speed;
        }
        public int getSpeed()
        {
            return this.Speed;
        }
        ////////////////
        public void setPiercingTireChance(int chance)
        {
            this.PiercingTireChance = chance;
        }
        public int getPiercingTireChance()
        {
            return this.PiercingTireChance;
        }
        public void nextMove(double a, double time)
        {
            if (this.Speed == 0)
            {
                this.Speed = 1;
            }

            double distance = Math.Min((double)this.Speed * time, a - this.CurrentDistance);
            this.CurrentDistance += distance;
            this.RoundTime += (distance / (double)this.Speed);
            int sleepTime = (int)(time * 1000d);

            Thread.Sleep(sleepTime);
            Console.WriteLine($"{this.GetType()} ::: {CurrentDistance}");
        }

        public void nextPierce()
        {
            int seconds = 1 + (rand.Next(3));
            this.RoundTime += (double)seconds;
            Console.WriteLine($"Прокол у {this.GetType()} остаток времени: {seconds}");
        }
    }
}
