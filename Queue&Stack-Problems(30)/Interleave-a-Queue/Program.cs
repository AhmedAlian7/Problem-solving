using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    /*         
                      ------------Problem-------------

            Interleave Queue Elements
            Problem: Interleave the first half of a queue with the second half.
            
            Example:
            Input: Queue = [1, 2, 3, 4, 5, 6]
            Output: Queue = [1, 4, 2, 5, 3, 6]

     */

    public class Program
    {

        static void InterleaveQueue(Queue<int> queue) // [1, 2, 3, 4, 5, 6]
        {
            if (queue == null || queue.Count % 2 != 0)
                throw new ArgumentException("Queue must have an even number of elements.");


            int halfSize = queue.Count / 2;
            Queue<int> firstHalf = new Queue<int>();

            // Step 1: Move first half into a new queue
            for (int i = 0; i < halfSize; i++)
            {
                firstHalf.Enqueue(queue.Dequeue());
            }

            // Step 2: Interleave elements
            while (firstHalf.Count > 0)
            {
                queue.Enqueue(firstHalf.Dequeue()); // First half element
                queue.Enqueue(queue.Dequeue());     // Second half element
            }
        }

        static void Main(string[] args)
        {
            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Queue<int> queue = new Queue<int>(arr);
            InterleaveQueue(queue);
            Console.WriteLine(string.Join(", ", queue));
            Console.ReadKey();
        }
    }
}
