using System;

namespace InterfacesDemo
{
    public abstract class Car
    {
        public Car(string brand, string model, string color)
        {
            Brand = brand;
            Model = model;
            Color = color;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public abstract bool IgnitionOn();
        public void IgnitionOff()
        {
            Console.WriteLine("Turn off all of the systems and engine.");
        }
    }

    public interface ICar
    {
        string Brand { get; set; }
        string Model { get; set; }
        string Color { get; set; }
        bool IgnitionOn();
        void IgnitionOff();
    }
}
