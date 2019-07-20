using System;
using System.Collections.Generic;

namespace delegatesandabstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car(450000, "BMW", "X7"),
                new Car(500000, "AUDI", "Q8")
            };

            cars[0].RegisterWithOnSpeedChange(Helper.ShowSpeed);

            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                var someValue = rand.Next(0, 2);
                cars[someValue].SpeedUp(2);
            }

            Helper.ShowCarsAndSpeed(cars);
        }
    }
}
