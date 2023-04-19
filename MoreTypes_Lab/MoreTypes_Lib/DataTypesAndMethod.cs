using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreTypes_Lib
{
    public class DataTypesAndMethod
    {
        static void Main(string[] args)
        {
            var myString = "  C# list fundamentals  ";
            Console.WriteLine(StringExercise(myString));

        }

        public static string StringExercise(string myString)
        {
            //1.Trim off any leading or trailing spaces from `myString`
            myString.Trim();
            //2.Turn all the characters to Upper Case
            myString.ToUpper();
            //3.Replace all occurances of the letters 'L' and 'T' with '*'
            myString.Replace('L', '*').Replace('T', '*');
            //4.Find the index of the letter 'N', and delete all the characters after it
            myString.Substring(0, myString.IndexOf('N') + 1);
            //5.Return the result
            return myString;
        }
    }
}
