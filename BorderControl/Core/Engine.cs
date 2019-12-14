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
        private List<IBirthdable> birthdates;

        public Engine()
        {
            creatures = new List<IIdentifiable>();
            birthdates = new List<IBirthdable>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input.Split();

                //Citizen Pesho 22 9010101122 10 / 10 / 1990
                //Pet Sharo 13 / 11 / 2005
                //Robot MK-13 558833251

                if (inputArgs[0] == "Robot")
                {
                    string model = inputArgs[1];
                    string id = inputArgs[2];

                    IIdentifiable robot = new Robot(model, id);
                    creatures.Add(robot);
                }
                else if (inputArgs[0] == "Citizen")
                {
                    string name = inputArgs[1];
                    int age = int.Parse(inputArgs[2]);
                    string id = inputArgs[3];
                    string birthdate = inputArgs[4];

                    IBirthdable citizen = new Citizen(name, age, id, birthdate);
                    birthdates.Add(citizen);
                }
                else if (inputArgs[0] == "Pet")
                {
                    string name = inputArgs[1];
                    string birthdate = inputArgs[2];

                    IBirthdable pet = new Pet(name, birthdate);
                    birthdates.Add(pet);
                }

              input = Console.ReadLine();
            }

            string year = Console.ReadLine();

            foreach (var item in birthdates.Where(x => x.Birthdate.EndsWith(year)))
            {
                Console.WriteLine(item.Birthdate);
            }
        }
    }
}
