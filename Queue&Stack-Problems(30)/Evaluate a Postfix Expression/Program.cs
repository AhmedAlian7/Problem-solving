using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    /*         
                            ------------Problem-------------

                Evaluate a Postfix Expression
                Problem: Evaluate a postfix expression using a stack.
                
                Example:
                - Input: "231*+9-"
                - Output: -4
    */

    public class Program
    {
        
        public static int EvaluatePostfixExpression(string expression)
        {
            var stack = new Stack<int>();

            foreach (var item in expression)
            {
                if (Char.IsNumber(item))
                {
                    stack.Push(item - '0');
                }
                else if (stack.Count > 1)
                {
                    int n1 = stack.Pop();
                    int n2 = stack.Pop();
                    switch (item)
                    {
                        case '*':
                            stack.Push(n2 * n1);
                            break;
                            

                        case '+':
                            stack.Push(n2 + n1);
                            break;
                            
                        case '/': 
                            stack.Push(n2 / n1);
                            break;
                            
                        case '-':
                            stack.Push(n2 - n1);
                            break;
                            
                    }
                }
            }
            return stack.Pop();
        }

        static void Main(string[] args)
        {

            string s = Console.ReadLine().Trim();

            Console.Write(EvaluatePostfixExpression(s));
            


            Console.ReadKey();
        }
    }
}
