using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            FuelCar vw = new FuelCar();
            ElectricCar tesla = new ElectricCar();

            vw.DisplayStatus();
            tesla.DisplayStatus();
            vw.BluetoothConnection();
            tesla.BluetoothConnection();

            Car vwAsCar = vw as Car;
            Car teslaAsCar = tesla as Car;
            vwAsCar.DisplayStatus();
            teslaAsCar.DisplayStatus();

            Vehicle vwAsVehicle = vw as Vehicle;
            Vehicle teslaAsVehicle = tesla as Vehicle;
            //vwAsVehicle.DisplayStatus();
            //teslaAsVehicle.DisplayStatus();

            //IAndroidAuto androidAutoCar = teslaAsVehicle as IAndroidAuto;
            //androidAutoCar.BluetoothConnection();
            DoSomething(vwAsVehicle);
            DoSomething(teslaAsVehicle);
            Console.ReadKey();
        }

        //przyklad
        private static void DoSomething(Vehicle vehicle)
        {
            vehicle.DisplayStatus();
        }
    }
}
