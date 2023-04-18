using System;
using System.Collections.Generic;
using System.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        // Returns if nums are equal or if num1 is divisable by num2
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            if (nums != null) return nums.Count() == 0 ? throw new ArgumentOutOfRangeException("List Empty") : nums.Average();
            throw new ArgumentNullException("Parameter was Null");
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            if (age < 5) return "Free";
            else if (age < 13) return "Child";
            else if (age < 18) return "Student";
            else if (age < 60) return "Standard";
            else return "OAP";
        }

        public static string Grade(int mark)
        {
            if (mark < 0 && mark > 100) throw new ArgumentOutOfRangeException("Invalid Parameters");
            else if (mark > 39 && mark < 60) return "Pass";
            else if (mark > 59 && mark < 75) return "Pass with Merit";
            else if (mark > 74) return "Pass with Distinction";
            else return "Fail";

            //  return mark < 40 ? "Fail" : mark < 60 ? "Pass" : mark < 75 ? "Pass with Merit" : "Pass with Distinction";

        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            switch (covidLevel)
            {
                case 4:
                    return 20;
                case 3:
                    return 50;
                case 2:
                    return 50;
                case 1:
                    return 100;
                case 0:
                    return 200;
                default:
                    throw new ArgumentOutOfRangeException("Invalid Parameters: accepts 0 - 4");
            }
        }
    }
}
