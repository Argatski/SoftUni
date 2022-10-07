namespace BirthdayCelebrations
{
    public class Mammal : IMammal
    {
        public Mammal(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
        public string Name { get; private set; }

        public string Birthdate { get; private set; }

        public override string ToString()
        {
            return $"{this.Birthdate}";
        }
    }
}
