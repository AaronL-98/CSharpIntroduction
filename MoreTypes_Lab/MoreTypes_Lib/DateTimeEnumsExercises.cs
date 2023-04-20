using System;
using System.Reflection.Metadata.Ecma335;

namespace MoreTypes_Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class DateTimeEnumsExercises
    {
        // returns a person's age at a given date, given their birth date.
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            if (date < birthDate) throw new ArgumentException("Error - birthDate is in the future");

            //int age = date.Year - birthDate.Year;
            //if ((birthDate.Month > date.Month) || (birthDate.Month == date.Month && birthDate.Day > date.Day)) age--;
            //return age;

            var diff = date - birthDate;
            int age1 = (int)(diff.Days / 365.25);
            return age1;

        }
        // returns a date formatted in the manner specified by the unit test
        public static string FormatDate(DateTime date)
        {
            return date.ToString("yy/dd/MMM");
        }

        // returns the name of the month corresponding to a given date
        public static string GetMonthString(DateTime date)
        {
            return date.ToString("MMMM");
        }

        // see unit tests for requirements
        public static string Fortune(Suit suit)
        {
            switch (suit)
            {
                case Suit.HEARTS:
                    return "You've broken my heart";
                case Suit.CLUBS:
                    return "And the seventh rule is if this is your first night at fight club, you have to fight.";
                case Suit.DIAMONDS:
                    return "Diamonds are a girls best friend";
                default:
                    return "Bucket and spade";
            }
        }
    }
}
