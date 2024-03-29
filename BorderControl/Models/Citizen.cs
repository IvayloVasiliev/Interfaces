﻿using BorderControl.Contracts;

namespace BorderControl.Models
{
    public class Citizen : IIdentifiable, IBirthdable, IBuyer
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;
        private int food;

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
            Food = 0;
        }

        public string Name { get => name; private set => name = value; }
        public int Age { get => age; private set => age = value; }
        public string Id { get => id; private set => id = value; }
        public string Birthdate { get => birthdate; private set => birthdate = value; }
        public int Food { get => food; set => food = value; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
