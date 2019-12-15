using ExplicitInterfaces.Contracts;
using System;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split();
                string name = inputArgs[0];
                string country = inputArgs[1];
                int age = int.Parse(inputArgs[2]);               

                Citizen citizen = new Citizen(name, country, age);

                Console.WriteLine(citizen.GetName());
                Console.WriteLine(((IResident)citizen).GetName());

            }
        }
    }
}
