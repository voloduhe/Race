using System;
using System.Collections.Generic;
using System.Text;


namespace RaceProject
{
    class Truck : Vehicle
    {
        private int Weight;

        public Truck(int speed, int chance, int weight)
        {
            this.setSpeed(speed);
            this.setPiercingTireChance(chance);
            this.setWeight(weight);
        }

        public void setWeight(int weight)
        {
            this.Weight = weight;
        }
        public int getWeight()
        {
            return this.Weight;
        }
        public override string ToString()
        {
            return $"Скорость грузовика: {this.getSpeed()} Груз: {this.Weight}";
        }
    }
}
