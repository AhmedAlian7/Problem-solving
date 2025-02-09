using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    /*         
                                    ------------Problem-------------

                Rearrange Queue Alternately
                Problem: Rearrange elements in a queue alternately in increasing and decreasing order.
                
                Example:
                Input: Queue = [1, 2, 3, 4, 5, 6]
                Output: Queue = [1, 6, 2, 5, 3, 4]
     */

    public class Program
    {

        public static Queue<int> RearrangeQueueAlternately(Queue<int> queue) // 1 2 3
        {                                                               // 6 5 4
            List<int> list = new List<int>(queue);
            Queue<int> result = new Queue<int>();
            int n = list.Count;

            for(int i =0; i < n/2; ++i)
            {
                result.Enqueue(list[i]);
                result.Enqueue(list[n -i -1]);
            }
            return result;
        }

        static void Main(string[] args)
        {
            var Q = new Queue<int>(new int[] { 1, 2, 3, 4, 5, 6 });

            Console.WriteLine(string.Join(" ", RearrangeQueueAlternately(Q)));

            Console.ReadKey();
        }
    }
}
