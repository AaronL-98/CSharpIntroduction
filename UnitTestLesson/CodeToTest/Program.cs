using System.Globalization;
using System.Runtime.CompilerServices;

namespace CodeToTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int timeOfDay = 21;
            var myGreeting = Greeting(timeOfDay);
            Console.WriteLine(myGreeting);

        }

        /*Funtion to display a greeting based on the time of day given to the funtion*/
        public static string Greeting(int timeOfDay) 
        {
            string greeting;
            if (timeOfDay >= 5 && timeOfDay < 12)
            {
                greeting = "Good Morning";
            }
            else if (timeOfDay >= 12 && timeOfDay < 18)
            {
                greeting = "Good Afternoon";
            }
            else
            {
                greeting = "Good Evening";
            }
            return greeting;
        }
        
    }
}