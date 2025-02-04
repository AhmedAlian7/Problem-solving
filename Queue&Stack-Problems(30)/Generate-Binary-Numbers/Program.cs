using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    /*         
                      ------------Problem-------------

            Generate Binary Numbers
            Problem: Generate binary numbers from 1 to N using a queue.
            
            Example:
            Input: N = 5
            Output: ["1", "10", "11", "100", "101"]


     */

    public class Program
    {

        static void GenerateBinaryNumbers(int n)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");


            for (int i = 0; i < n; i++)
            {
                string binary = queue.Dequeue(); // 1
                Console.WriteLine(binary);
                queue.Enqueue(binary + "0");
                queue.Enqueue(binary + "1");
            }
        }

        static void Main(string[] args)
        {
            //var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            var number = Convert.ToInt32(Console.ReadLine());
            GenerateBinaryNumbers(number);

        }
    }
}
