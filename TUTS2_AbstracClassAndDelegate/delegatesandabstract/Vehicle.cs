using System;
using System.Collections.Generic;
using System.Text;

namespace delegatesandabstract
{
    public abstract class Vehicle
    {
        public string Color { get; set; }
        public float Speed { get; private set; }

        public void SpeedUp(int value = 1)
        {
            Speed += value;
            listOfHandlers?.Invoke(this);
        }

        public void SlowDown(int value = 1) => Speed = -1;

        public abstract decimal Price { get; set; }

        public abstract void RunDiagnostic();

        public delegate void OnSpeedChangeHandler(Vehicle vehicle);
        private OnSpeedChangeHandler listOfHandlers;

        public void RegisterWithOnSpeedChange(OnSpeedChangeHandler methodToCall)
        {
            listOfHandlers = methodToCall;
        }
    }
}
