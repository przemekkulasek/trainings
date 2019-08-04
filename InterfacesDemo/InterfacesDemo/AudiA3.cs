using InterfacesDemo.Interfaces;
using System;

namespace InterfacesDemo
{
    public class AudiA3 : Audi, IMultimediaSystem
    {
        public AudiA3(string color) : base("a3", color){}

        public override int NumOfSpeakers { get => 4; }
        public override int ScreenSize { get => 4; }

        public override void VolumeDown()
        {
            Volume--;
            Console.WriteLine($"Volume down");
        }

        public override void VolumeUp()
        {
            Volume++;
            Console.WriteLine($"Volume up");
        }
    }
}
