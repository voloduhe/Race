using System;
using System.Collections.Generic;
using System.Text;

namespace RaceProject
{
    class Car : Vehicle
    {
        private int People;

        public Car(int speed, int chance, int people)
        {
            this.setSpeed(speed);
            this.setPiercingTireChance(chance);
            this.setPeople(people);
        }

        public void setPeople(int people)
        {
            this.People = people;
        }
        public int getPeople()
        {
            return this.People;
        }
        public override string ToString()
        {
            return $"Скорость машины: {this.getSpeed()} Людей: {this.People}";
        }

    }
}
