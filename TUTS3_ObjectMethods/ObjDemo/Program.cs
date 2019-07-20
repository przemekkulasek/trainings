using System;
using System.Collections;

namespace ObjDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(1, "Ford", "Mustang", 450);
            Car car2 = new Car(2, "Ford", "Mustang", 450);
            Car car3 = new Car(3, "Ferrari", "Italia", 550);
            Car car4 = car3;

            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());
            Console.WriteLine(car3.ToString());
            Console.WriteLine(car4.ToString());

            Console.WriteLine(car1.GetHashCode());
            Console.WriteLine(car2.GetHashCode());
            Console.WriteLine(car3.GetHashCode());
            Console.WriteLine(car4.GetHashCode());

            Console.WriteLine(car1.Equals(car2));
            Console.WriteLine(car3.Equals(car4));

            Hashtable hashtable = new Hashtable();
            hashtable.Add(car1, "1st car");
            hashtable.Add(car2, "2nd car");
            hashtable.Add(car3, "3rd car");

            Console.ReadKey();
        }
    }
}
