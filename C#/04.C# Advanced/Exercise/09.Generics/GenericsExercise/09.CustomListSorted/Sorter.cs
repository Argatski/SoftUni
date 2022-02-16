using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CustomListSorted
{
    public class Sorter
    {
        public static void Sort<T>(ref CustomList<T> list)
        where T : IComparable<T>
        {
            List<T> sorted = list.OrderBy(e => e).ToList();

            list = new CustomList<T>(sorted);
        }
    }
}
