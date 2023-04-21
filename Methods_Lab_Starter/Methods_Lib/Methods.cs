using System;

namespace Methods_Lib
{
    public class Methods
    {
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            return (totalDays < 0) ? throw new ArgumentOutOfRangeException("totalDays must not be negative") : ((totalDays / 7), (totalDays % 7));

        }

        public static int RollDice(Random rng)
        {
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            return num1 + num2;
        }

        public static (int squareInput, int cubeInput, double sqrtInput) PowersRoot(int input)
        {
            if (input < 0) throw new ArgumentOutOfRangeException("Can't sqaure root a negative number");

            checked
            {
                int squareInput = input * input;

                int cubeInput = (int)Math.Pow(input, 3);

                double sqrtInput = Math.Sqrt(input);
                
                return (squareInput, cubeInput, sqrtInput);
            }
        }

    }
}
