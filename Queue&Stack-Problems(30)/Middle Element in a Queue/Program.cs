using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    /*         
                                        ------------Problem-------------

                       Find Middle Element in a Queue
                       Problem: Find the middle element of a queue without modifying it.
                       
                       Example:
                       Input: Queue = [1, 2, 3, 4, 5]
                       Output: 3
                       
     */

    public class Program
    {

        public static int MiddleOfQueue(Queue<int> queue)
        {
            if (queue.Count % 2 == 0) 
                throw new ArithmeticException("Queues with Even Number of Elements not Allowed");

            List<int> list = new List<int>(queue);
            return list[list.Count / 2];
        }


        static void Main(string[] args)
        {

            Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });

            Console.Write(MiddleOfQueue(queue));
            


            Console.ReadKey();
        }
    }
}
