using System;

namespace RaceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike(200,10,true);

            Console.WriteLine(bike.ToString());

            bike.nextPierce();
        }
    }
}
