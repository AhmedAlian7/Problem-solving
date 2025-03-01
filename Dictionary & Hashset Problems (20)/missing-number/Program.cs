using System;
using System.Collections.Generic;

namespace Problem_Solving
{

    /*
                            -----------------Problem-----------------
     
                Find Missing Number in an Array
                Problem: Find the missing number in an array of size n containing numbers from 0 to n.
                
                Example:
                - Input: [3, 0, 1]
                - Output: 2

     */


    public class Solution
    {
        public int MissingNumber(int[] nums)
        {

            var set = new HashSet<int>(nums);

            for (int i = 0; i < nums.Length; ++i)
            {
                if (!set.Contains(i)) return i;
            }
            return -1;
        }
    }


    public class Progam
    {
       
        public static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.MissingNumber([3, 0, 1]));
        }
    }
}




