using System.Globalization;
using System.Runtime.CompilerServices;

namespace CodeToTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int timeOfDay = 21;
            int age = 16;
            var myGreeting = Greeting(timeOfDay);
            var filmsAvailable = AvailableClassifications(age);
            Console.WriteLine(myGreeting);
            Console.WriteLine(filmsAvailable);

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

        public static string AvailableClassifications(int ageOfViewer)
        {
            string result;
            if (ageOfViewer < 12)
            {
                result = "U, PG Films are available.";
            }
            else if (ageOfViewer < 15)
            {
                result = "U, PG & 12 Films are available.";
            }
            else if (ageOfViewer < 18)
            {
                result = "U, PG, 12 & 15 Films are available.";
            }
            else
            {
                result = "All Films are available.";
            }
            return result;
        }

    }
}