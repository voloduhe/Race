using System;
using System.Collections.Generic;
using System.Text;

namespace RaceProject
{
    class Bike : Vehicle
    {
        private bool Sidecar;

        public Bike(int speed, int chance, bool sidecar)
        {
            this.setSpeed(speed);
            this.setPiercingTireChance(chance);
            this.setSideCar(sidecar);
        }

        public void setSideCar(bool sidecar)
        {
            this.Sidecar = sidecar;
        }
        public bool getSidecar()
        {
            return this.Sidecar;
        }
        public override string ToString()
        {
            return $"Скорость мотоцикла: {this.getSpeed()} Коляска: {this.Sidecar}";
        }
        
    }
}
