using System;
using System.Collections.Generic;
using System.Linq;

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
        public static bool isPalindromeQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>(queue);

            foreach (int item in queue)
            {
                if (item != stack.Pop())
                    return false;
            }
            return true;
        }
       
        static void Main(string[] args)
        {
            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            if (isPalindromeQueue(new Queue<int>(arr)))
                Console.WriteLine("TRUE");
            else
                Console.WriteLine("FALSE");

        }
    }
}
