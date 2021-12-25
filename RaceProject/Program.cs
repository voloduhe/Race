using System;
using System.Threading;
using System.Collections.Generic;

namespace RaceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike(200, 10, true);

            int time = 10000;

            List<Vehicle> vehicles = new List<Vehicle>()
            {
                new Bike(200, 10, true),
                new Car(100, 1, 4),
                new Truck(250, 40, 400)
            };

            List<Moving> moving = new List<Moving>()
            {
                new Moving(vehicles[0],time,50000),
                new Moving(vehicles[1],time,50000),
                new Moving(vehicles[2],time,50000)
            };


            List<Thread> threads = new List<Thread>()
            {
                new Thread(moving[0].GoThread),
                new Thread(moving[1].GoThread),
                new Thread(moving[2].GoThread)
            };
        }
    }
}
