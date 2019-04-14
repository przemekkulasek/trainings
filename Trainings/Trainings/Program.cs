using System;
using Trainings.DataTypes;

namespace Trainings
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"OS VERSION: {Environment.OSVersion}");
            Console.WriteLine($"Username: {Environment.UserName}");

            //numeric values
            Console.WriteLine(Numeric.ValuesRange());

            //default literal
            int defaultLiteral = default;
            Console.WriteLine($"defaultLiteral: {defaultLiteral}");

            //digit separator
            Console.WriteLine($"digit separator: {123_456_789L}");

            //108 - pattern matching

        }
    }
}
