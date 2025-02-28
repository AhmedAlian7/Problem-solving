using System;
using System.Collections.Generic;

namespace Problem_Solving
{

    /*
                            -----------------Problem-----------------
     
                Problem: Find the majority element in an array (element appearing more than n/2 times).

                Example:
                - Input: [3, 2, 3]
                - Output: 3

     */

    public class Progam
    {
        public static int majorityElement(int[] nums)
        {
            int n = nums.Length;
            var dic = new Dictionary<int, int>();

            foreach ( var item in nums)
            {
                if(dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic.Add(item, 1);
                }
                if (dic[item] > n / 2)
                {
                    return item;
                }
            }
            return -1;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine(majorityElement([3, 2, 3]));
        }
    }
}




