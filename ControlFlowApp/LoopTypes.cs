using System;
using System.Collections.Generic;

namespace ControlFlowApp
{
    public static class LoopTypes
    {
        public static void Loops()
        {
            List<int> nums = new List<int> { 10, 6, 22, -17, 3};
            Console.WriteLine("Highest foreach loop: " + LoopTypes.HighestForEachLoop(nums));
            Console.WriteLine("Highest for loop: " + LoopTypes.HighestForLoop(nums));
            Console.WriteLine("Highest while loop: " + LoopTypes.HighestWhileLoop(nums));
            Console.WriteLine("Highest do-while loop: " + LoopTypes.HighestDoWhileLoop(nums));
        }

        public static int HighestDoWhileLoop(List<int> nums)
        {
            int output = nums.First();
            int i = 1;
            do
            {
                if (nums[i] > output) output = nums[i];
                i++;
            }
            while (i < nums.Count());

            return output;
        }

        public static int HighestWhileLoop(List<int> nums)
        {
            int output = nums.First();
            int i = 1;
            while (i < nums.Count())
            {
                if (nums[i] > output) output = nums[i];
                i++;
            }
            return output;
        }

        public static int HighestForLoop(List<int> nums)
        {
            int output = nums.First();
            for(int i = 1; i < nums.Count(); i++)
            {
                if (nums[i] > output) output = nums[i];
            }
            return output;
        }

        public static int HighestForEachLoop(List<int> nums)
        {
            int output = 0;
            foreach (int i in nums) 
            {
                if (i > output) output = i;
            }
            return output;
        }
    }
}
