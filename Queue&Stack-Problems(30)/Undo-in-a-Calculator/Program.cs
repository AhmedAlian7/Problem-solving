using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    /*         
              ------------Problem-------------
              
         Implement undo functionality in a calculator.

     */

    public class Program
    {
        public class Calculator
        {
            public Stack<string> History { get; set; } = new Stack<string>();
            public string currentOperation { get { return History.Count == 0 ? "Nothing" : History.Peek(); } }

            public void Do(string operation)
            {
                History.Push(operation);
            }
            public void Undo()
            {
                if (History.Count > 0)
                { History.Pop(); }
            }
        }

        static void Main(string[] args)
        {
            Calculator calculater = new Calculator();

            calculater.Do("10 + 2");
            calculater.Do("3 * 30");
            calculater.Do("98 - 23");
            calculater.Undo();
            Console.WriteLine(calculater.currentOperation);
            calculater.Undo();
            Console.WriteLine(calculater.currentOperation);
        }
    }
}
