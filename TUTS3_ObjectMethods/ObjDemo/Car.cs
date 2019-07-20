using System;
using System.Collections.Generic;
using System.Text;

namespace ObjDemo
{
    public class Car
    {
        public Car(int uniqueId, string brand, string type, int horsePower)
        {
            UniqueId = uniqueId;
            Brand = brand;
            Type = type;
            HorsePower = horsePower;
        }
        public int UniqueId { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public int HorsePower { get; private set; }

        public override string ToString()
        {
            return $"{Brand} {Type}";
        }

        public override bool Equals(object obj)
        {
            if(obj is Car && obj != null)
            {
                Car car = (Car)obj;
                if(car.Brand == this.Brand && car.Type == this.Type)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return UniqueId;
        }
    }
}
