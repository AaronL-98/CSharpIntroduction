using System.ComponentModel.Design;

namespace ControlFlowApp
{
    public class GradeChecker
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            try
            {
                Console.WriteLine(CheckGrade(-20));
                Console.WriteLine(CheckGrade(82));
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }


            //Console.WriteLine(Priority(2));
            
            //Console.WriteLine(DrivingLaw(17));
            //Console.WriteLine(DrivingLaw(20));
            //Console.WriteLine(DrivingLaw(25));

            //LoopTypes.Loops();

        }

        public static string CheckGrade(int score)
        {
            if (score < 0 || score > 100)
            {
                throw new ArgumentOutOfRangeException("score:" + score + " Allowed Range 0-100");
            }

            // 0 - 100 
            // variable //if       nested if                                else
            return (score >= 65) ? (score >= 85 ? "Distinction" : "Pass") : "Fail";
        }

        public static string DrivingLaw(int age)
        {
            string law = "";
            switch (age)
            {
                case < 18:
                    law = "Cannot Legally Drive";
                    break;
                case < 23:
                    law = "Can Legally Drive but Cannot Hire a car";
                    break;
                default:
                    law = "Can Legally Drive and Rent a car";
                    break;
            }
            return law;
        }

        public static string Priority(int level)
        {
            string priority = "Code ";
            switch (level) 
            {
                case 3:
                    priority = priority + "Red";
                    break;
                case 2:
                        // Will skip to the next case
                case 1:
                    priority = priority + "Chartreuse";
                    break;
                case 0:
                    priority = priority + "Cyan";
                    break;
                default:
                    priority = "Error";
                    break;
             
            }
            return priority;
        }

    }
}