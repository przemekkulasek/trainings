using InterfacesDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    public abstract class Audi : Car, INameClashExample 
    {
        private int volume = 0;
        public Audi(string model, string color) : base("audi", model, color){}

        public abstract int NumOfSpeakers { get; }
        public abstract int ScreenSize { get; }
        public int Volume { get => volume; set => volume = value; }

        public override bool IgnitionOn()
        {
            Console.WriteLine("Run all audi built in systems.");
            return true;
        }

        public abstract void VolumeDown();

        public abstract void VolumeUp();
    }
}
