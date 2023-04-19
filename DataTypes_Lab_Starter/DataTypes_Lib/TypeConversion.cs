using System;

namespace DataTypes_Lib
{
    public class TypeConversion
    {
        public static short UIntToShort(uint num)
        {
            //if (num > short.MaxValue) throw new OverflowException("input value greater than short value limit");

            //return (short)num;

            return Convert.ToInt16(num);
        }

        public static long FloatToLong(float num)
        {
            return (long)Math.Round(num);
        }
    }
}