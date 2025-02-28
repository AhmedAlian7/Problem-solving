using System;
using System.Collections.Generic;

namespace Problem_Solving
{

    /*
                    -----------------Problem-----------------
     
                Find All Unique Elements
                Problem: Return all unique elements from an array.
                
                Example:
                - Input: [1, 2, 2, 3, 4, 5, 3]
                - Output: [1, 4, 5]

     */

    public class Progam
    {
        public static IList<int> FindUniques(int[] nums)
        {
            var dic = new Dictionary<int, int>();
            var res = new List<int>();
            foreach (int num in nums)
            {
                if (dic.ContainsKey(num))
                    dic[num]++;
                else
                    dic.Add(num, 1);
                

            }

            foreach (var item in dic)
            {
                if (item.Value == 1)
                    res.Add(item.Key);
            }
            return res;
        }


        public static void Main(string[] args)
        {
            var res = string.Join(",", FindUniques([1, 2, 2, 3, 4, 5, 3]));
            Console.WriteLine($"[{res}]");
        }
    }
}




