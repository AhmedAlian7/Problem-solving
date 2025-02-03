using System;
using System.Collections.Generic;
using System.Threading;

namespace Problem_Solving
{
    /*         
              ------------Problem-------------
              
            Use a queue to manage printer jobs.

     */

    public class Program
    {
        public class Printer
        {
            public Queue<string> Tasks { get; set; } = new Queue<string>();
            public string currentTask { get { return Tasks.Count == 0 ? "Nothing" : Tasks.Peek(); } }

            public void Add(string document)
            {
                Tasks.Enqueue(document);
            }
            public void Print()
            {
                if (Tasks.Count > 0)
                { Tasks.Dequeue(); }
            }
            public void PrintAll()
            {
                while (Tasks.Count > 0)
                {
                    string current = Tasks.Dequeue();
                    Console.WriteLine($"Printing {current} ...");
                    Thread.Sleep(1000);
                }
            }
        }

        static void Main(string[] args)
        {
            Printer printer = new Printer();

            printer.Add("xyz.txt");
            printer.Add("abc.txt");
            printer.Add("doc.txt");
            printer.Add("aaa.txt");

            printer.PrintAll();
        }
    }
}
