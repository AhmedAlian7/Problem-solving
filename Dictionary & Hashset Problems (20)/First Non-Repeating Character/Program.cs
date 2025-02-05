using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_Solving
{
    /*         
                                        ------------Problem-------------

            First Non-Repeating Character in a Stream
            Problem: Given a stream of characters, find the first non-repeating character after each insertion.
            
            Example:
            Input: "aabc"
            Output: a, -, b, c

     */

    public class Program
    {

        static void NonRepeatingChars(string stream) // aabc
        {
            HashSet<char> chars = new HashSet<char>();

            foreach (char c in stream)
            {
                if (chars.Add(c))
                    Console.Write($"{c} ");
                else
                    Console.Write("- ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            NonRepeatingChars(Console.ReadLine().Trim());
            Console.ReadKey();
        }
    }
}
