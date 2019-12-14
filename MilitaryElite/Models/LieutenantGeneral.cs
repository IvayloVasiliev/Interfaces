using MilitaryElite.Contracts;
using System.Collections.Generic;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            Privates = new List<IPrivate>();
        }

        public ICollection<IPrivate> Privates 
        { get;
          set;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nPrivates:\n {string.Join("\n ", Privates)}";
        } 
    }
}
