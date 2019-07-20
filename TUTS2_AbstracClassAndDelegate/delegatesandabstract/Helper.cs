using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegatesandabstract
{
    static class Helper
    {
        public static void ShowCarsAndSpeed(List<Car> cars)
        {
            Console.WriteLine(string.Join(", ", cars.Select(c => $"{c.Brand}(speed: {c.Speed})")));
        }

        public static void ShowSpeed(Vehicle vehicle)
        {
            if(vehicle is Car)
            {
                var car = vehicle as Car;
                Console.WriteLine($"{car.Brand}(speed: {car.Speed})");
            }
        }
    }
}
