using System.Text;

namespace MoreDataTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myString = "  C# list fundamentals  ";
            Console.WriteLine(StringExercise(myString));
            Console.WriteLine(StringBuilderExercise(myString));
            StringInterpolation("Aaron");
            ParsingStrings();

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

    }
}