using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_Solving
{
    /*         
                                                    ------------Problem-------------

               Rearrange Even and Odd Elements
               Problem: Rearrange a queue such that all even numbers appear before odd numbers while maintaining their order.
               
               
               Example:
               Input: Queue = [1, 2, 3, 4, 5,6]
               Output: Queue = [2, 4, 6, 1, 3, 5]
               
     */

    public class Program
    {

        public static Queue<int> EvenOddQueue(Queue<int> queue) // 1, 2, 3, 4, 5, 6
        {
            var envenQueue = new Queue<int>();
            var oddQueue = new Queue<int>();

            while(queue.Count > 0)
            {
                var item = queue.Dequeue();
                if (item  % 2 == 0)
                    envenQueue.Enqueue(item); // 2, 4, 6
                else
                    oddQueue.Enqueue(item); // 1, 3 ,5, 6
            }

            return new Queue<int>(envenQueue.Concat(oddQueue));
        }


        static void Main(string[] args)
        {
            var queue = new Queue<int>(new int[] { 1, 2, 3 ,4 ,5, 6});
           

            Console.WriteLine(string.Join(", ", EvenOddQueue(queue)));

            Console.ReadKey();
        }
    }
}
