﻿using System;
using System.Collections.Generic;
using System.Text;

namespace refoutrefvalue
{
    public class Car
    {
        public Car(string brand, string type)
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
