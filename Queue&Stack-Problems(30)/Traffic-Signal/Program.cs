using System;
using System.Collections.Generic;
using System.Threading;

namespace Problem_Solving
{
    /*         
                        ------------Problem-------------
              
            Traffic Signal System Simulation
            Problem: Simulate vehicles waiting at a traffic signal.
            
            Vehicles are processed in the order they arrive (FIFO), and after processing,
            the next vehicle moves up.

     */

    public class Program
    {
        public class TrafficSignal
        {
            public Queue<string> Vehicles { get; set; } = new Queue<string>();
            public string current { get { return Vehicles.Count == 0 ? "Nothing" : Vehicles.Peek(); } }

            public void Arrived(string vehicle)
            {
                Vehicles.Enqueue(vehicle);
            }
            public void Start()
            {
                Console.WriteLine("Traffic Signal Simulation Started...\n");
                while (Vehicles.Count > 0)
                {
                    string current = Vehicles.Dequeue();

                    Console.WriteLine($"{current} has passed the signal.");
                    Console.WriteLine($"Vehicles waiting: {string.Join( ", ", Vehicles)}\n");
                    Thread.Sleep(1000);
                }
            }
        }

        static void Main(string[] args)
        {
            TrafficSignal signal = new TrafficSignal();

            signal.Arrived("Car1");
            signal.Arrived("Truck1");
            signal.Arrived("Bike1");
            signal.Arrived("Bus1");

            signal.Start();
        }
    }
}
