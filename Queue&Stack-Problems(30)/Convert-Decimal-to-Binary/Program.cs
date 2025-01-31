using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving
{
    /*         
               ------------Problem-------------
              
        Convert a decimal number to binary using a stack.

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
            return toString(stack);
        }
        public static string toString(Stack<char> stack)
        {
            var result = new StringBuilder();
            while (stack.Count > 0)
            {
                result.Append( stack.Pop());
            }
            return result.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(toBinary(24));
        }
    }
}
