using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Engine
    {
        private ICallable caller;
        private IBrowsable browser;
        
        public Engine(ICallable caller, IBrowsable browser)
            : this(caller)
        {
            this.browser = browser;
        }
        public void Run()
        {
            string[] numbers = Console.ReadLine()
              .Split();

            string[] sites = Console.ReadLine()
                          .Split();

            CallNumbers(numbers);
            BrowserSites(sites);
        }

        private void BrowserSites(string[] sites)
        {
            foreach (var site in sites)
            {
                try
                {
                    Console.WriteLine(this.browser.Browsing(site));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    continue;
                }
            }
        }

        private void CallNumbers(string[] numbers)
        {
            foreach (var num in numbers)
            {
                try
                {
                    if (num.Length == 10)
                    {
                        Console.WriteLine(this.caller.Call(num));
                    }
                    else if (num.Length == 7)
                    {
                        caller = new StationaryPhone();
                        Console.WriteLine(this.caller.Call(num));
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }

                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    continue;
                }
            }
        }
    }
}
