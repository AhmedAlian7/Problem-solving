using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    /*         
                    ------------Problem-------------
              
        Use a stack to implement a browser's back button functionality.

     */

    public class Program
    {
        public class Browser
        {
            public Stack<string> History {  get; set; } = new Stack<string>();
            public string currentURL { get { return History.Count == 0 ? "Nothing" : History.Peek(); } }

            public void GoTo(string uRL)
            {
                History.Push(uRL);
            }
            public void Backward()
            {
                if (History.Count > 0)
                { History.Pop(); }
            }
        }

        static void Main(string[] args)
        {

            Browser browser = new Browser();

            browser.GoTo("page1");
            browser.GoTo("page2");
            browser.GoTo("page3");
            browser.GoTo("page4");
            browser.Backward();
            Console.WriteLine(browser.currentURL);
            browser.Backward();
            Console.WriteLine(browser.currentURL);
        }
    }
}
