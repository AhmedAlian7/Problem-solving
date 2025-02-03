using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    /*         
                      ------------Problem-------------

            Reverse a Queue
            Problem: Given a queue, reverse its elements.
            
            Example:
            - Input: Queue = [1, 2, 3, 4, 5]
            - Output: Queue = [5, 4, 3, 2, 1]
     */

    public class Program
    {
        public static Queue<int> ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
            return queue;
        }

        static void Main(string[] args)
        {
            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            var reversedQ = ReverseQueue(new Queue<int>(arr));

            foreach (var item in reversedQ)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}
