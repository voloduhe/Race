using System;
using System.Collections.Generic;
using System.Text;

namespace RaceProject
{
    class Race
    {
        private List<Vehicle> VehiclesList;
        private double distanceRace;
        private string path;
        public Race(string path)
        {
            this.path = path;
        }
        public void Start()
        {
            Console.WriteLine("ГОНКИ НАЧАЛИСЬ");
        }

    }
}
