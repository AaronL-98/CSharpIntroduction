namespace CodeToTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeOfDay = 21;
            NewMethod(timeOfDay);
        }

        private static void NewMethod(int timeOfDay)
        {
            if (timeOfDay >= 5 && timeOfDay < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (timeOfDay >= 12 && timeOfDay < 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            else
            {
                Console.WriteLine("Good Evening");
            }
        }

    }
}