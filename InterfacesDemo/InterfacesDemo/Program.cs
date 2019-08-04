using InterfacesDemo.Interfaces;
using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IAndroidAuto a8 = new AudiA8("black");
            a8.VolumeUp();
            Console.WriteLine(a8.Volume);
            a8.UseAndroidMaps();
            a8.VolumeDown();
            Console.WriteLine(a8.Volume);

            //IMultimediaSystem a3 = new AudiA3("red");
            //a3.VolumeUp();
            //a3.VolumeDown();
            //Console.WriteLine(a3.Volume);

            INameClashExample example = new AudiA8("pink");
            example.VolumeDown();

            Console.ReadKey();
        }
    }
}
