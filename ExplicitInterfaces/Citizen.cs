﻿using ExplicitInterfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public class Citizen : IPerson, IResident
    {
        public Citizen(string name, string country, int age)
        {
            Name = name;
            Age = age;
            Country = country;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Country { get; private set; }

        public string GetName()
        {
            return Name;
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {Name}";
        }
    }
}
