using System;
namespace BirthdayCelebrations
{
    public class Citizen : Mammal, IIdentifiable
    {
        public Citizen(string name, int age, string id, string birthdate)
            : base(name, birthdate)
        {
            this.Age = age;
            this.Id = id;
        }

        public string Id { get; private set; }
        public int Age { get; private set; }
    }
}
