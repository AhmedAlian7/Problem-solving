using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    /*         
                            ------------Problem-------------

                Check Balanced Parentheses
                Problem: Check if a given string has balanced parentheses.
                        
                Input: "({[]})" or "({[)]}"
                Output: true for "({[]})" and false for "({[)]}"

    */

    public class Program
    {
        private static bool isOpening(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }
        private static bool isClosing(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }
        public static bool isBalancedParentheses(string s) 
        {
            var map = new Dictionary<char, char>();
            map.Add(')', '(');
            map.Add(']', '[');
            map.Add('}', '{');


            var stack = new Stack<char>();

            foreach (var c in s) // "({[]})"
            {
                if (isOpening(c))
                { 
                    stack.Push(c); // ( { [ 
                }
                else if (isClosing(c))
                {
                    if (stack.Count == 0 ||     // There is no opening parentheses
                        map[c] != stack.Peek()) // Open brackets must be closed in the correct order
                        return false;
                    else
                        stack.Pop(); // Valid open/closed parntheses
                }
            }
            return stack.Count == 0; // Ensure that there is no opening parantheses
        }

        static void Main(string[] args)
        {

            string s = Console.ReadLine().Trim();

            Console.Write(isBalancedParentheses(s));
            


            Console.ReadKey();
        }
    }
}
