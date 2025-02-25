


using System.Net.Security;
using System.Text;

namespace Problem_Solving
{

    /*
                        ---------------------Problem---------------------
     
                Remove Invalid Parentheses
                Problem: Remove the minimum number of invalid parentheses to make the string valid.
                
                Example:
                - Input: "(()))"
                - Output: "(())"
     
     */

    public class Progam
    {
        public static string RemoveInvalidParentheses(string s) // "()()("
        {
            var stack = new Stack<int>();
            var invalidIndices = new HashSet<int>();
            

            for (int i =0; i < s.Length; ++i)
            {
                char c = s[i];

                if (c == '(')
                {
                    stack.Push(i);
                }
                else if (c == ')')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        invalidIndices.Add(c);
                    }
                }
            }
            while (stack.Count > 0)
            {
                invalidIndices.Add(stack.Pop());
            }

            var result = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (!invalidIndices.Contains(i))
                {
                    result.Append(s[i]);
                }
            }

            return result.ToString();
        }

        public static void Main(string[] args)
        {
            string s = Console.ReadLine().Trim();
            Console.WriteLine(RemoveInvalidParentheses(s));
        }
    }
}




