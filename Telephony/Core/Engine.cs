using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Core
{
    public class Engine
    {
        public void Run()
        {
            Smartphone smartphone = new Smartphone();

            string[] inputNumbers = Console.ReadLine().Split();
            string[] inputUrls = Console.ReadLine().Split();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                smartphone.Call(inputNumbers[i]);
            }

            for (int i = 0; i < inputUrls.Length; i++)
            {
                smartphone.Browse(inputUrls[i]);
            }
        }


    }
}
