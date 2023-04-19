using System;

namespace DataTypes_Lib
{
    public static class IntegerCalc
    {
        public static int Add(int num1, int num2)
        {
            //if ((num1 == int.MaxValue && num2 > 0) || (num1 > 0 && num2 == int.MaxValue)) throw new OverflowException();
            //else if ((num1 == int.MinValue && num2 < 0) || (num1 < 0 && num2 == int.MinValue)) throw new OverflowException();
            //else return num1 + num2;
            int result = num1 + num2;

            if (result < 0 && num1 > 0 && num2 > 0) throw new OverflowException();
            else if (result > 0 && num1 < 0 && num2 < 0) throw new OverflowException();
            else return result;
            //throw new NotImplementedException();
        }

        public static int Subtract(int num1, int num2)
        {
            return checked(num1 - num2);
        }

        public static int Multiply(int num1, int num2)
        {
            return checked(num1 * num2);
        }

        public static int Divide(int num1, int num2)
        {
            return num2 == 0 ? throw new ArgumentException("Can't divide by zero") : num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {

            return num2 == 0 ? throw new ArgumentException("Can't modulo by zero") : num1 % num2;
        }
    }
}
