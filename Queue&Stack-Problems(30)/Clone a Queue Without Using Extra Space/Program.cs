using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    /*         
                                        ------------Problem-------------

                       Clone a Queue Without Using Extra Space
                       Problem: Clone a queue such that the original queue remains unchanged.
               
                       Example:
                       Input: Queue = [1, 2, 3, 4]
                       Output: Clone = [1, 2, 3, 4]

     */

    public class Program
    {

        public static Queue<int> CloneQueue(Queue<int> queue)
        {
            if (queue.Count == 0) return new Queue<int>();

            int size = queue.Count;
            Queue<int> clone = new Queue<int>();

            for (int i = 0; i < size; i++)
            {
                int front = queue.Dequeue();
                clone.Enqueue(front);
                queue.Enqueue(front); // Restore the original queue
            }
            return clone;
        }


        static void Main(string[] args)
        {

            Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4 });

            Console.Write("Original Queue Before Cloning: ");
            Console.WriteLine(string.Join(", ", queue));

            Queue<int> clonedQueue = CloneQueue(queue);
            Console.Write("Cloned Queue: ");
            Console.WriteLine(string.Join(", ", clonedQueue));

            Console.Write("Original Queue After Cloning: ");
            Console.WriteLine(string.Join(", ", queue));


            Console.ReadKey();
        }
    }
}
