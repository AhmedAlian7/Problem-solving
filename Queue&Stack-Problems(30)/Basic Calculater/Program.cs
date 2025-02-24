


namespace Problem_Solving
{

    /*
                        ---------------------Problem---------------------
     
                Basic Calculator
                Problem: Evaluate a mathematical expression containing +, -, (, ) without * or /.
                
                Example:
                - Input: "1 + (2 - 3)"
                - Output: 0
     
     */

    public class Calculater
    {
        private static bool IsOperator(char c) =>   c == '+' || c == '-' || c == '*' || c == '/' || c == '^';
        private static int GetPrecedence(char op)
        {
            return op switch
            {
                '+' or '-' => 1,
                '*' or '/' => 2,
                _ => -1,
            };
        }
        private static string ToPostfix(string infix) // 3*(5-3)
        {
            var stack = new Stack<char>();                  // *
            string postfix = "";                            // 353-*

            for (int i = 0; i < infix.Length; i++)
            {
                char c = infix[i];

                if (char.IsDigit(c))
                {
                    while (i < infix.Length && char.IsDigit(infix[i]))
                    {
                        postfix += infix[i];
                        i++;
                    }
                    postfix += ' ';
                    i--;
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postfix += stack.Pop();
                    }
                    stack.Pop(); // Remove '('
                }
                else if (IsOperator(c))
                {
                    while (stack.Count > 0 && GetPrecedence(stack.Peek()) >= GetPrecedence(c))
                    {
                        postfix += stack.Pop();
                    }
                    stack.Push(c);
                }
            }

            while (stack.Count > 0)
            {
                postfix += stack.Pop();
            }

            return postfix;
        }

        private static int EvaluatePostfix(string expression)
        {
            var stack = new Stack<int>();

            foreach (var item in expression)
            {
                if (char.IsDigit(item))
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

        public static int Calculate(string expression)
        {
            return EvaluatePostfix(ToPostfix(expression));  
        }

    }

    public class Progam
    {
        public static void Main(string[] args)
        {
            string exp = Console.ReadLine().Trim();
            Console.WriteLine(Calculater.Calculate(exp));
        }
    }
}




