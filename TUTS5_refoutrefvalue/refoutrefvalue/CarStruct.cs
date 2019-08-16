using System;
using System.Collections.Generic;
using System.Text;

namespace refoutrefvalue
{
    public struct CarStruct
    {

        public CarStruct(string v1, string v2) : this()
        {
            this.Brand = v1;
            this.Type = v2;
        }

        public string Brand { get; set; }
        public string Type { get; set; }

        public override string? ToString()
        {
            return $"{Brand} {Type}";
        }
    }
}
