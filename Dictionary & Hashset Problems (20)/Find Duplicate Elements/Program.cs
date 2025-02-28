using System;
using System.Collections.Generic;

namespace Problem_Solving
{

    /*
                    -----------------Problem-----------------
     
                Find Duplicate Elements
                Problem: Identify duplicate elements in an array.
                
                Example:
                - Input: [1, 2, 3, 4, 2, 5, 6, 1]
                - Output: [1, 2]

     */

    public class Progam
    {
        public static IList<int> FindDuplicates(int[] nums)
        {
            var dic = new Dictionary<int, int>();
            var res = new List<int>();
            foreach (int num in nums)
            {
                if (dic.ContainsKey(num))
                    dic[num]++;
                else
                    dic.Add(num, 1);
                
                if (dic[num] >= 2)
                    res.Add(num);
            }
            return res;
        }


        public static void Main(string[] args)
        {
            var res = string.Join(",", FindDuplicates([1]));
            Console.WriteLine($"[{res}]");
        }
    }
}




