namespace OperatorsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 5;
            x++;
            ++y;
            int a = x++;
            int b = ++y;
            int c = x;
            for (int lb = 1; lb <= 5; ++lb) 
            {
                Console.WriteLine(lb);
            }


            var d = 5 / 2; // integer 
            var e = 5.0 / 2; // double
            var f = 5 / 3; // integer
            double g = 5 / 2; // double 2.0

            var h = 20 % 2;

            /* Refactor to use DateTime and auto update */
            var daysInAWeek = 7;
            var totalDaysToBirthsay = 23;
            var weeksToBirthday = totalDaysToBirthsay / daysInAWeek;
            var days = totalDaysToBirthsay % daysInAWeek;

            var i = 1;
            i += 3;

            var j = 3;
            j += 2;

        }
    }

}