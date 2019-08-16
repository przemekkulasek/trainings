using System;

namespace refoutrefvalue
{
    class Program
    {
        //stack (stos): value types
        //heap (sterta): reference types
        
        //ref, in, out
        
        //value types: 
            //struct 
            //enum
            //simple types: bool, char, float, double, decimal, sbyte, byte, short, ushort, int, uint, long, ulong, date
        
        //reference types: class, interface, delegate, dynamic, object, string, arrays, indexers

        static void Main(string[] args)
        {
            //ref int
            int x = 0;
            modifyValue(ref x);
            Console.WriteLine(x);

            //ref int
            int t = 0;
            modifyValueIn(in t);
            Console.WriteLine(t);

            //int
            int z = 0;
            modifyValue(z);
            Console.WriteLine(z);

            //dynamic
            dynamic y = 0;
            modifyValue(y);
            Console.WriteLine(y);

            //car class
            var car = new Car("orginał", "orginał");
            modifyCarClass(car);
            Console.WriteLine(car.ToString());

            //car struct
            var car2 = new CarStruct("orginał", "orginał");
            modifyCarStruct(car2);
            Console.WriteLine(car2.ToString());

            Console.ReadKey();
        }

        private static void modifyValue(ref int val)
        {
            val = 999;
        }

        //https://devblogs.microsoft.com/premier-developer/the-in-modifier-and-the-readonly-structs-in-c/
        private static void modifyValueIn(in int val) //ref readonly
        {
            //val = 999;
        }

        private static void modifyValue(int val)
        {
            val = 999;
        }

        private static void modifyValue(dynamic val)
        {
            val = 999;
        }

        private static void modifyCarClass(Car car)
        {
            car = new Car("zmodyfikowany", "zmodyfikowany");
            //car.Brand = "zmodyfikowany";
            //car.Type = "zmodyfikowany";
        }

        private static void modifyCarStruct(CarStruct car)
        {
            car = new CarStruct("zmodyfikowany", "zmodyfikowany");
            //car.Brand = "zmodyfikowany";
            //car.Type = "zmodyfikowany";
        }
    }
}
