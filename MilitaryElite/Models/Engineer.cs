﻿using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System.Collections.Generic;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary, corps)
        {
            Repairs = new List<IRepair>();
        }

        public ICollection<IRepair> Repairs { get; set;}

        public override string ToString()
        {
            return base.ToString() + $"\nCorps: {Corps}\nRepairs:{(Repairs.Count == 0 ? "" : "\n")}" +
                $"{string.Join("\n ", Repairs)}";
        }
    }
}
