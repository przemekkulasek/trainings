using System;
using System.Collections.Generic;
using System.Text;

namespace Trainings.DataTypes
{
    public static class Numeric
    {
        public static string ValuesRange()
        {
            StringBuilder sb = new StringBuilder();

            //signed integers
            sb.AppendLine();
            sb.AppendLine($"sbyte min:{sbyte.MinValue} max:{sbyte.MaxValue} bits:8");
            sb.AppendLine($"short min:{short.MinValue} max:{short.MaxValue} bits:16");
            sb.AppendLine($"int min:{int.MinValue} max:{int.MaxValue} bits:32");
            sb.AppendLine($"long min:{long.MinValue} max:{long.MaxValue} bits:64");

            //unsigned integers
            sb.AppendLine($"byte min:{byte.MinValue} max:{byte.MaxValue} bits:8");
            sb.AppendLine($"ushort min:{ushort.MinValue} max:{ushort.MaxValue} bits:16");
            sb.AppendLine($"uint min:{uint.MinValue} max:{uint.MaxValue} bits:32");
            sb.AppendLine($"ulong min:{ulong.MinValue} max:{ulong.MaxValue} bits:64");
            sb.AppendLine("Prefferred types are int and long.");
            //real numbers
            sb.AppendLine($"float min:{float.MinValue} max:{float.MaxValue} bits:32");
            sb.AppendLine($"double min:{double.MinValue} max:{double.MaxValue} bits:64");
            sb.AppendLine($"decimal min:{decimal.MinValue} max:{decimal.MaxValue} bits:128");
            sb.AppendLine("double = science, decimal = economy");
            sb.AppendLine();

            return sb.ToString();
        }

    }
}
