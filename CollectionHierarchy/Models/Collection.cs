using CollectionHierarchy.Contracts;
using System.Collections.Generic;

namespace CollectionHierarchy.Models
{
    public abstract class Collection : IAdd
    {
        private List<string> list;

        protected Collection()
        {
            list = new List<string>();
        }

        public List<string> List 
        {
            get
            {
                return list;
            }
        }

        public abstract int Add(string element);
    }
}
