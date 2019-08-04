using InterfacesDemo.Interfaces;
using System;

namespace InterfacesDemo
{
    public class AudiA8 : Audi, IAndroidAuto, IAppleCarPlay, INameClashExample
    {
        public AudiA8(string color) : base("a8", color){}

        public override int NumOfSpeakers { get => 12; }
        public override int ScreenSize { get => 11; }

        public void RunAndroidApp(string appName)
        {
            Console.WriteLine($"Running android app: {appName}");
        }

        public void RunIosApp(string appName)
        {
            Console.WriteLine($"Running ios app: {appName}");
        }

        public void UseAndroidMaps()
        {
            Console.WriteLine($"Use android maps");
        }

        public void UseIosMaps()
        {
            Console.WriteLine($"Use ios maps");
        }

        public override void VolumeDown()
        {
            Volume--;
            Console.WriteLine($"Volume down implicit");
        }

        public override void VolumeUp()
        {
            Volume++;
            Console.WriteLine($"Volume up");
        }
    }
}
