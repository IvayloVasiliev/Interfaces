using BorderControl.Contracts;
using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl.Core
{
    public class Engine
    {
        private List<IIdentifiable> creatures;

        public Engine()
        {
            creatures = new List<IIdentifiable>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input.Split();

                if (inputArgs.Length == 2)
                {
                    string model = inputArgs[0];
                    string id = inputArgs[1];

                    IIdentifiable robot = new Robot(model, id);
                    creatures.Add(robot);
                }
                else
                {
                    string name = inputArgs[0];
                    int age = int.Parse(inputArgs[1]);
                    string id = inputArgs[2];

                    IIdentifiable citizen = new Citizen(name, age, id);
                    creatures.Add(citizen);
                }

              input = Console.ReadLine();
            }

            string fakeId = Console.ReadLine();

            foreach (var creature in creatures.Where(x => x.Id.EndsWith(fakeId)))
            {
                Console.WriteLine(creature.Id);
            }

            creatures.RemoveAll(x => x.Id.EndsWith(fakeId));
        }
    }
}
