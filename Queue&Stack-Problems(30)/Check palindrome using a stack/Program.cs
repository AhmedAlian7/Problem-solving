using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    /*         
                            ------------Problem-------------

                Check palindrome using a stack 
                Problem:
                Check if a given string is a palindrome using a stack.
                
                - Input: "madam"
                - Output: true

                - Input: "hello"
                - Output: false
    */

    public class Program
    {
        
        public static bool isPalindrome(string s)
        {
            var stack = new Stack<char>(s);

            foreach (var c in s)
            {
                if (c != stack.Pop())
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {

            string s = Console.ReadLine().Trim();

            Console.Write(isPalindrome(s));
            


            Console.ReadKey();
        }
    }
}
