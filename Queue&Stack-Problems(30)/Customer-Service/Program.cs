using System;
using System.Collections.Generic;
using System.Threading;

namespace Problem_Solving
{
    /*         
                             ------------Problem-------------
              
           Customer Service Simulation
           Problem: Simulate a customer service system where customers are served in the order they arrive.

           Example:
           - Input: Customers arriving at different times.
           - Output: Serve customers in a first-come, first-served order.
           
           Key Points:
           - Use a queue to maintain the order of customer arrivals.
           - Dequeue customers when they are served.

     */

    public class Program
    {
        public class CustomerService
        {
            public Queue<string> Services { get; set; } = new Queue<string>();
            public string currentTask { get { return Services.Count == 0 ? "Nothing" : Services.Peek(); } }

            public void Add(string service)
            {
                Services.Enqueue(service);
            }
            public void Start()
            {
                while (Services.Count > 0)
                {
                    string current = Services.Dequeue();
                    Console.WriteLine($"Serving {current} ...");
                    Thread.Sleep(1000);
                }
            }
        }

        static void Main(string[] args)
        {
            CustomerService service = new CustomerService();
            service.Add("customer1");
            service.Add("customer2");
            service.Add("customer3");
            service.Add("customer4");
            service.Add("customer5");
            service.Start();

        }
    }
}
