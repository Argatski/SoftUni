namespace Zoo
{
    public class Animal
    {
        public string Species { get; set; }
        public string Diet { get; set; }
        public double Weight { get; set; }
        public double Lenght { get; set; }

        public Animal()
        {

        }
        /// <summary>
        /// Constructor should receive (species,diet,weight and length)
        /// </summary>
        /// <param name="species"></param>
        /// <param name="diet"></param>
        /// <param name="weight"></param>
        /// <param name="lenght"></param>
        public Animal(string species, string diet, double weight, double lenght)
        {
            Species = species;
            Diet = diet;
            Weight = weight;
            Lenght = lenght;
        }

        public override string ToString()
        {
            return $"The {Species} is a {Diet} and weighs {Weight} kg.";
        }
    }
}
