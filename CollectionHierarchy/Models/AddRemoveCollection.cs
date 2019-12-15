using CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models
{
    public class AddRemoveCollection : AddCollection, IRemove
    {
        public AddRemoveCollection()
            : base()
        {
        }

        public override int Add(string element)
        {
            List.Insert(0, element);

            return 0;
        }

        public virtual string Remove()
        {
            string element = List[List.Count - 1];
            List.RemoveAt(List.Count - 1);
            return element;
        }
    }
}
