using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public sealed class ElectricCar : Car, IAndroidAuto
    {
        public ElectricCar() : base("tesla", "p90") { }
        public override Energy EnergyType => Energy.Electric;

        public void BluetoothConnection()
        {
            Console.WriteLine("Bluetooth connected.");
        }

        public override void SpeedUp()
        {
            Speed += 4;
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("I'm tesla");
        }
    }
}
