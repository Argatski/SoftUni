using CollectionHierarchy.Contracts;
using System.Collections.Generic;

namespace CollectionHierarchy.Models
{
    public abstract class Collection : IAddCollections
    {
        public Collection()
        {
            this.Data = new List<string>();
        }

        protected List<string> Data { get; }
        public virtual int Add(string item)
        {

            var index = 0;
            this.Data.Insert(index, item);
            return index;
        }

    }
}
