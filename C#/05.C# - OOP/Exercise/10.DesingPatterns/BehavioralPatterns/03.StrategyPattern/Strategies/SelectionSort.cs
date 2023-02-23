﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StrategyPattern.Strategies
{
    internal class SelectionSort : ISortingStrategy
    {
        public void Sort(List<int> collection)
        {
            Console.WriteLine("Selection sort");
        }
    }
}
