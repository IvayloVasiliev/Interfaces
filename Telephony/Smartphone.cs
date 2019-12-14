﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Contracts;

namespace Telephony
{
    public class Smartphone : ICallable, IBrawsebale
    {
        public void Browse(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                Console.WriteLine("Invalid URL!");
                
            }
            else 
            {
                Console.WriteLine($"Browsing: {url}");
            }
        }

        public void Call(string number)
        {
            if (number.All( x => char.IsDigit(x)))
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
