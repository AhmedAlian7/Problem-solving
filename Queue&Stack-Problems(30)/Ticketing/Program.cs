using System;
using System.Collections.Generic;
using System.Threading;

namespace Problem_Solving
{
    /*         
                             ------------Problem-------------
              
            Ticketing System Simulation
            Problem: Simulate a ticketing system where customers are served in the order they arrive.
            When a customer’s ticket is processed, the next ticket is queued for service.

     */

    public class Program
    {
        public class Ticketing
        {
            public Queue<int> Tickets { get; set; } = new Queue<int>();
            public int current { get { return Tickets.Count == 0 ? 0 : Tickets.Peek(); } }

            public void IssueTicket(int ticketId)
            {
                Tickets.Enqueue(ticketId);
                Console.WriteLine($"Ticket {ticketId} issued.");
                Thread.Sleep(500);
            }
            public void Start()
            {
                Console.WriteLine("\nTicketing System Simulation Started...\n");
                while (Tickets.Count > 0)
                {
                    int current = Tickets.Dequeue();

                    Console.WriteLine($"Processing Ticket: {current}");
                    if (Tickets.Count == 0)
                        Console.WriteLine("No more tickets in the queue");
                    else
                        Console.WriteLine($"Remaining Tickets: {string.Join(", ", Tickets)}\n");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("\nTicketing System Simulation Ended.\n");

            }
        }

        static void Main(string[] args)
        {
            Ticketing ticketing = new Ticketing();
            ticketing.IssueTicket(101);
            ticketing.IssueTicket(102);
            ticketing.IssueTicket(103);
            ticketing.IssueTicket(104);
            ticketing.IssueTicket(105);

            ticketing.Start();
        }
    }
}
