using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MoreDataTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //--STRINGS--
            //var myString = "  C# list fundamentals  ";
            //Console.WriteLine(StringExercise(myString));
            //Console.WriteLine(StringBuilderExercise(myString));
            //StringInterpolation("Aaron");
            //ParsingStrings();
            
            //--ARRAYS--
            OneDArray();
            MultiDArray();
            JaggedArray();
        }

        public static string StringExercise(string myString)
        {
            //1.Trim off any leading or trailing spaces from `myString`
            string output = myString.Trim();
            //2.Turn all the characters to Upper Case
            output = output.ToUpper();
            //3.Replace all occurances of the letters 'L' and 'T' with '*'
            output = output.Replace('L', '*').Replace('T', '*');
            //4.Find the index of the letter 'N', and delete all the characters after it
            output = output.Substring(0, output.IndexOf('N') + 1);
            //5.Return the result
            return output;
        }

        public static string StringBuilderExercise(string myString)
        {
            string trimmedUpperString = myString.Trim().ToUpper();
            int nPos = trimmedUpperString.IndexOf('N');
            var sb = new StringBuilder(trimmedUpperString);
            sb.Replace('L', '*').Replace('T', '*').Remove(nPos + 1, sb.Length - nPos - 1);
            
            return sb.ToString();
        }

        public static void StringInterpolation(string str)
        {
            Console.WriteLine("My name is : " + str + " using +");
            Console.WriteLine(string.Concat("My name is : ", str, " using interpolation"));
            Console.WriteLine($"My name is : {str} using interpolation" );

            int num1 = 2;
            var num2 = 7;
            var fString = $"{num1} to the power of {num2} is {Math.Pow(num1, num2)}";
            Console.WriteLine(fString);
            var fString2 = $"Log to the base {num2} of {num1} is {Math.Log(num2, num1)}";
            Console.WriteLine(fString2);
            var fString3 = $"That will be £{num2 / 3.0} please!";
            Console.WriteLine(fString3);
        }

        public static void ParsingStrings()
        {
            Console.WriteLine("How many apples?");
            string input = Console.ReadLine(); ;
            //bool success = Int32.TryParse(input, out int numApples);

            while (!Int32.TryParse(input, out int numApples))
            {
                Console.WriteLine("Value must be an integer");
                input = Console.ReadLine();
            }
            //try 
            //{
            //    int numApples = Int32.Parse(input);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("must be and integer");
            //}
        }

        public static void OneDArray()
        {
            int[] myIntArray = { 12, 23, 34, 45, 56 };
            Array.Reverse(myIntArray);
            foreach (var i in myIntArray) 
            {
                Console.WriteLine(i);
            }
        }

        public static void MultiDArray()
        {
            int[,] grid = 
            { 
                { 12, 1 }, 
                { 23, 2 }, 
                { 34, 3 }, 
                { 45, 4 }, 
                { 56, 5 } 
            };

            Console.WriteLine("2D Grid written to console");
            foreach (var i in grid)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("2D Grid written to console by row");
            for (var i = grid.GetLowerBound(0); i <= grid.GetUpperBound(0); i++)
            {
                for (var j = grid.GetLowerBound(1); j <= grid.GetUpperBound(1); j++)
                {
                    Console.Write($"({i}, {j}) = {grid[i, j]}");
                }
                Console.WriteLine();
            }
        }

        public static void JaggedArray()
        {
            int[][] jArray = new int[2][];
            jArray[0] = new int[4];
            jArray[1] = new int[2];

            Console.WriteLine("Jagged Array written to console by row");
            string[][] jArray2 = new string[][]
            {
                new string[] {"llama", "puma", "horse", "kitten"},
                new string[] {"haddock", "tuna"}
            };

            foreach (var row in jArray2)
            {
                foreach (var entry in row)
                {
                    Console.Write($"{entry} ");
                }
                Console.WriteLine();
            }

        }

    }
}