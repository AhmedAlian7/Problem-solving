using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_Solving
{
    /*         
                        ------------Problem-------------

                Queue Using Two Stacks
                Problem: Implement a queue using two stacks.
            
                Example:
                Operations: Enqueue(1), Enqueue(2), Dequeue(), Dequeue()
                Output: 1 , 2

     */

    public class Program
    {

        public class MyQueue<T>
        {
            private Stack<T> _stack1 = new Stack<T>();
            private Stack<T> _stack2 = new Stack<T>();

            public void Enqueue(T value)
            {
                _stack1.Push(value);
            }
            public T Dequeue()
            {
                if (_stack2.Count == 0)
                {
                    while (_stack1.Count > 0)
                    {
                        _stack2.Push(_stack1.Pop());
                    }
                }
                return _stack2.Pop();
            }
        }

        static void Main(string[] args)
        {
            MyQueue<int> queue = new MyQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.ReadKey();
        }
    }
}
