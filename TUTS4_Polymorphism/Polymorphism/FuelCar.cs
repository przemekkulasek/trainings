using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class FuelCar : Car, IAndroidAuto
    {
        public FuelCar() : base("vw", "golf") { }
        public override Energy EnergyType => Energy.Fuel;

        public void BluetoothConnection()
        {
            Console.WriteLine("Not connected!");
        }

        public override void SpeedUp()
        {
            Speed += 2;
        }

        public new void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("I'm golf");
        }
    }
}
