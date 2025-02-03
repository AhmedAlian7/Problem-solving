using System;
using System.Collections.Generic;
using System.Threading;

namespace Problem_Solving
{
    /*         
                             ------------Problem-------------
              
            Task Scheduling
            Problem: Given a set of tasks with a specific order,
            simulate the order of execution using a queue. Example:
            
            - Input: ["Task1", "Task2", "Task3", "Task4"]
            - Output: Execute tasks in the order they appear.
            
            Key Points:
            
            - Enqueue tasks in the given order.
            - Dequeue and process them one at a time.

     */

    public class Program
    {
        public class TaskSchedule
        {
            public Queue<string> Tasks { get; set; } = new Queue<string>();
            public string currentTask { get { return Tasks.Count == 0 ? "Nothing" : Tasks.Peek(); } }

            public void Add(string[] tasks)
            {
                foreach (string task in tasks)
                {
                    Tasks.Enqueue(task);
                }
            }
            public void Start()
            {
                while (Tasks.Count > 0)
                {
                    string current = Tasks.Dequeue();
                    Console.WriteLine($"Executing {current} ...");
                    Thread.Sleep(1000);
                }
            }
        }

        static void Main(string[] args)
        {
            TaskSchedule schedule = new TaskSchedule();
            schedule.Add(new string[] { "task1", "task2", "task3", "task4" });
            schedule.Start();

        }
    }
}
