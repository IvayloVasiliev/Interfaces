using CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models
{
    public class AddCollection : Collection
    {
        public AddCollection()
            : base()
        {
        }

        public override int Add(string element)
        {
            List.Add(element);
            return List.Count - 1;
        }
    }
}
