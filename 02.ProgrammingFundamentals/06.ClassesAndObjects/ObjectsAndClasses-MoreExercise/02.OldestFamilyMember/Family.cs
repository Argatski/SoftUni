using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.OldestFamilyMember
{
    class Family
    {
        public List<Person> People;

        public Family()
        {
            People = new List<Person>();
        }

        public void AddMembers(Person perCurr)
        {
            People.Add(perCurr);
        }

        public Person GetOldestMember(Family family)
        {
            List<Person> sorted = People.OrderByDescending(a => a.Age).ToList();
            return sorted[0];
        }
        
        
    }
}
