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

        public static string toBinary(int input)
        {
            if (input == 0) return "0";

            var stack = new Stack<char>();
            while (input > 0)
            {
                stack.Push((input % 2 == 0) ? '0' : '1');
                input /= 2;
            }
            return string.Join("",stack);
        }
        public static string[] GenerateBinaryNumbers(int number)
        {

            var BinaryNumbers = new string[number];
            for (int i = 1; i <= number; i++)
            {
                BinaryNumbers[i -1] = toBinary(i);
            }
            return BinaryNumbers;
        }
       
        static void Main(string[] args)
        {
            //var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(string.Join(", ", GenerateBinaryNumbers(number)));

        }
    }
}
