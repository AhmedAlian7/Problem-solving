using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    /*         
                      ------------Problem-------------

            Rotate a Queue
            Problem: Rotate a queue by K positions.
            
            Example:
            Input: Queue = [1, 2, 3, 4, 5], K = 2
            Output: Queue = [3, 4, 5, 1, 2]

     */

    public class Program
    {

        static void RotateQueueByK(Queue<int> queue, int k) // [1, 2, 3, 4, 5, 6]
        {

            for (int i = 0; i < k; ++i)
            {
                queue.Enqueue(queue.Dequeue());
            }

        }

        static void Main(string[] args)
        {
            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var k = Convert.ToInt32(Console.ReadLine());
            Queue<int> queue = new Queue<int>(arr);
            RotateQueueByK(queue, k);
            Console.WriteLine(string.Join(" ", queue));
            Console.ReadKey();
        }
    }
}
