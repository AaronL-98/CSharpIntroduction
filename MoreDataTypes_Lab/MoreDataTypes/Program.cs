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

    }
}