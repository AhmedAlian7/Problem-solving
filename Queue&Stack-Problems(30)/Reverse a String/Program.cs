using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving
{
/*         
                        ------------Problem-------------

                    Reverse a String
                    Problem: Reverse a given string using a stack.
                       
                    Input: "hello"
                    Output: "olleh"
                       
     */

    public class Program
    {

        public static string Reverse(string s)
        {
            var stack = new Stack<char>(s);

            var reversedString = new StringBuilder();
            while(stack.Count > 0)
            {
                reversedString.Append(stack.Pop());
            }
            return reversedString.ToString();
        }

        static void Main(string[] args)
        {

            string s = Console.ReadLine().Trim();

            Console.Write(Reverse(s));
            


            Console.ReadKey();
        }
    }
}
