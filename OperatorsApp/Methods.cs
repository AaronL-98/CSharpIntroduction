using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsApp
{
    public struct StonePound
    {
        int stone;
        int pound;
    }

    public class Methods
    {
        public static int GetStones(int totalPounds)
        {
            if (totalPounds < 0)
            {
                Console.WriteLine("Parameter must Be Positive");
                throw new ArgumentException("Invalid Parameters: Must be Positive");
            }
            else if (totalPounds > 1400)
            {
                Console.WriteLine("Parameter Excedes Limit");
                throw new ArgumentException("Invalid Parameters: Exceed Limit");
            }

                return totalPounds / 14; // return whole number of stones
        }

        public static int GetPounds(int totalPounds)
        {
            if (totalPounds < 0)
            {
                Console.WriteLine("Parameter must Be Positive");
                throw new ArgumentException("Invalid Parameters: Must be Positive");

            }
            else if (totalPounds > 1400)
            {
                Console.WriteLine("Parameter Excedes Limit");
                throw new ArgumentException("Invalid Parameters: Exceed Limit");
            }

            return totalPounds % 14; // return number of pounds left over
        }
    }
}
