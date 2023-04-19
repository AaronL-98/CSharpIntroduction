using System;

namespace DataTypes_Lib
{
    public static class Methods
    {
        // write a method to return the product of all numbers from 1 to n inclusive
        public static long Factorial(int n)
        {

            if (n == 0) return 0;

            long output = 1;
            for (int i = 1; i <= n; i++)
            {
                output *= i;
            }

            return output;

        }

        public static float Mult(float num1, float num2)
        {
            return checked(num1 * num2);
        }
    }
}
