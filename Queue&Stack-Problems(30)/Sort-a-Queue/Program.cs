using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    /*         
                      ------------Problem-------------

            Sort a Queue
            Problem: Sort elements in a queue in ascending order.
            
            Example:
            Input: Queue = [5, 1, 3, 2, 4]
            Output: Queue = [1, 2, 3, 4, 5]

     */

    public class Program
    {

        static Queue<int> SortQueue(Queue<int> q)
        {
            var list  = new List<int>(q);
            list.Sort();

            return new Queue<int>(list);
        }

        static void Main(string[] args)
        {
            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            
            var queue = SortQueue(new Queue<int>(arr));
            Console.WriteLine(string.Join(" ", queue));
        }
    }
}
