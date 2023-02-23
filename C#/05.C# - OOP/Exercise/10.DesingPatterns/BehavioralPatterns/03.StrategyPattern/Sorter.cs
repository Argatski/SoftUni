using _03.StrategyPattern.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StrategyPattern
{
    internal class Sorter
    {
        private ISortingStrategy sortingStrategy;
        public Sorter(ISortingStrategy sortingStrategy)
        {
            this.sortingStrategy = sortingStrategy;
        }
        public void Sort(List<int> collection)
        {
            sortingStrategy.Sort(collection);
        }
    }
}
