using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_Solving
{
    /*         
                                        ------------Problem-------------

                Implement a Priority Queue
                Problem: Implement a priority queue where elements with higher priority are dequeued first.
                
                Example:
                Input: Enqueue(10, 1), Enqueue(5, 3), Enqueue(20, 2), Dequeue()
                Output: 5 (highest priority first)
     */

    public class Program
    {

        public class PriorityQueue<T>
        {
            private SortedDictionary<int, Queue<T>> sortedDic;
            public PriorityQueue()
            {
                sortedDic = new SortedDictionary<int, Queue<T>>();
            }

            public void Enqueue(T item, int priority)
            {
                if (!sortedDic.ContainsKey(priority))
                {
                    sortedDic[priority] = new Queue<T>();
                }
                sortedDic[priority].Enqueue(item);
            }
            public T Dequeue()
            {
                if (sortedDic.Count == 0) throw new Exception();


                int highestPriority = sortedDic .Keys.Max();
                T value = sortedDic[highestPriority].Dequeue();
                if (sortedDic[highestPriority].Count == 0)
                {
                    sortedDic.Remove(highestPriority);
                }
                return value;
            }
        }

        static void Main(string[] args)
        {
            var queue = new PriorityQueue<int>();
            queue.Enqueue(10, 1);
            queue.Enqueue(5, 3);
            queue.Enqueue(20, 2);

            Console.WriteLine(queue.Dequeue());

            Console.ReadKey();
        }
    }
}
