using System;

namespace revoutrefvalue2
{
    class Program
    {
        //ref, out, in

        //value types: 
        //struct 
        //enum
        //simple types: bool, char, float, double, decimal, sbyte, byte, short, ushort, int, uint, long, ulong, date

        //reference types: class, interface, delegate, dynamic, object, string, arrays, indexers
        static void Main(string[] args)
        {
            var str = "poczatkowa";
            modifyValue(ref str);
            Console.WriteLine(str);
            Console.ReadKey();
        }

        private static void modifyValue(ref string s)
        {
            s += "modified";
        }
    }
}
