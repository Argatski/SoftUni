using System.Text;

namespace FishingNet
{
    public class Fish
    {
        //Properties
        public string FishType { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }

        //Constructor
        public Fish(string fishType, double length, double weight)
        {
            FishType = fishType;
            Length = length;
            Weight = weight;
        }

        /// <summary>
        /// Print the information about fish.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"There is a {FishType}, {Length} cm. long, and {Weight} gr. in weight.";
        }

    }
}
