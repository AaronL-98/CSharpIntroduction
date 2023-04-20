using System;
using System.Linq;

namespace MoreTypes_Lib
{


    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            input.Trim().ToUpper();
            for(int i = 0; i < num; i++)
            {
                input += i;
            }
            return input;
        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            return $"{number} {street}, {city} {postcode}.";
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            decimal percent = Math.Round((score / (decimal)outOf) * 100, 1);
            return $"You got {score} out of {outOf}: {percent}%";
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            if (double.TryParse(numString, out double i)) return i;
            return -999;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int a = 0, b = 0, c = 0, d = 0;
            foreach (char ch in input)
            {
                checked
                {
                    if (ch == 'A') a++;
                    else if (ch == 'B') b++;
                    else if (ch == 'C') c++;
                    else if (ch == 'D') d++;
                }
            }
            //a = input.Count(t => t == 'A');
            //b = input.Count(t => t == 'B');
            //c = input.Count(t => t == 'C');
            //d = input.Count(t => t == 'D');
            return $"A:{a} B:{b} C:{c} D:{d}";
        }
    }
}
