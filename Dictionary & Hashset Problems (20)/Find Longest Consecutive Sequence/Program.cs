using System;
using System.Collections.Generic;

namespace Problem_Solving
{

    /*
                        -----------------Problem-----------------
     
                Find Longest Consecutive Sequence
                Problem: Find the length of the longest consecutive sequence in an array.
                
                Example:
                - Input: [100, 4, 200, 1, 3, 2]
                - Output: 4

     */

    public class Progam
    {
        public static int LongestConsecutiveSequence(List<int> input)
        {
            if (input == null || input.Count == 0) return 0;
            input.Sort();
            int count =1, max = 1;
            for (int i = 0; i < input.Count -1; i++) // 0 1 1 2
            {
                if (input[i + 1] - input[i] == 0)
                    continue;

                if (input[i +1] - input[i] == 1)
                {
                    count++; // 3
                }
                else
                {
                    max = (max > count) ? max : count;
                    count = 1; 
                }
                
            }
            return (max > count) ? max : count;
        }

        public static int LongestConsecutiveSequenceUsingHashing(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            var set = new HashSet<int>(nums);
            int max = 0;
            foreach (int num in set)
            {
                if(!set.Contains(num -1)) // if true then it's start of sequence
                {
                    int current = num;
                    int count = 1;

                    while(set.Contains(current +1))
                    {
                        count ++;
                        current++;
                    }

                    max = (max > count) ? max : count; 
                }
            }
            return max;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine(LongestConsecutiveSequenceUsingHashing([0, 3, 7, 2, 5, 8, 4, 6, 0, 1]));
        }
    }
}




