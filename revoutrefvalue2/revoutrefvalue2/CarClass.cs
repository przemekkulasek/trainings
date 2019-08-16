using System;
using System.Collections.Generic;
using System.Text;

namespace revoutrefvalue2
{
    public class CarClass
    {
        public CarClass(string brand, string type)
        {
            Brand = brand;
            Type = type;
        }
        public string Brand { get; set; }
        public string Type { get; set; }

        public override string? ToString()
        {
            return $"{Brand} {Type}";
        }
    }
}
