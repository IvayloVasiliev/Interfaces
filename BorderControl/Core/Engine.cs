using BorderControl.Contracts;
using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl.Core
{
    public class Engine
    {
        private List<IBuyer> buyers;

        public Engine()
        {
            buyers = new List<IBuyer>();
        }

        public void Run()
        {
            int  n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();

                if (inputArgs.Length == 3)
                {
                    string name = inputArgs[0];
                    int age = int.Parse(inputArgs[1]);
                    string group = inputArgs[2];

                    IBuyer rebel = new Rebel(name, age, group);
                    buyers.Add(rebel);
                }
                else
                {
                    string name = inputArgs[0];
                    int age = int.Parse(inputArgs[1]);
                    string id = inputArgs[2];
                    string birthdate = inputArgs[3];

                    IBuyer citizen = new Citizen(name, age, id, birthdate);
                    buyers.Add(citizen);
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                IBuyer buyer = buyers.SingleOrDefault(b => b.Name == command);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}
