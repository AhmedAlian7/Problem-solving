using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    /*         
              ------------Problem-------------
              
        You are given n activities with their start and end times.
        Select the maximum number of activities that can be performed
        by a single person, assuming that a person can only work on a
        single activity at a time.

     */

    public class Program
    {
        class Activity
        {
            public int Start { get; set; }
            public int Finish { get; set; }
            public Activity(int start, int finish)
            {
                Start = start;
                Finish = finish;
            }
        }
        private static int ActivitySelection(List<Activity> activities)
        {
            if (activities == null)
                return 0;
            activities.Sort((a, b) => a.Finish.CompareTo(b.Finish));
            int counter = 1;
            var current = activities[0];
            for (var i = 1; i < activities.Count; ++i)
            {
                if (activities[i].Start >= current.Finish)
                { counter++; current = activities[i]; }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            List<Activity> list = new List<Activity>() { new Activity(1, 4), new Activity(3, 5), new Activity(0, 6), new Activity(5, 7), new Activity(8, 9), new Activity(5, 9) };
            Console.WriteLine($"{ActivitySelection(list)}");
        }
    }
}
