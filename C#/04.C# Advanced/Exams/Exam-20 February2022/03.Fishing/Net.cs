using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private readonly ICollection<Fish> fish;
        //public List<Fish> Fish = new List<Fish>();
        //Properties
        public string Material { get; set; }
        public int Capacity { get; set; }

        public int Count
        {
            get { return fish.Count; }
            private set { Count = value; }
        }

        //Construcotr
        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            this.fish = new List<Fish>();

        }

        public IReadOnlyCollection<Fish> Fish => (IReadOnlyCollection<Fish>)this.fish;
        //Methods
        /// <summary>
        /// Adds a Fish to the fish's collection if there is room for it. Before adding a fish, check:
        /// •	If the fish type is null or whitespace.
        /// •	If the fish’s length or weight is zero or less.
        /// •	If the fish type, length, or weight properties are not valid, return: "Invalid fish.". If the net is full (there is no room for more fish), return "Fishing net is full.". Otherwise, return: "Successfully added {fishType} to the fishing net."
        /// </summary>
        /// <param name="fish"></param>
        /// <returns></returns>
        public string AddFish(Fish fish)
        {

            bool isValidInput = string.IsNullOrWhiteSpace(fish.FishType) || fish.Length <= 0 || fish.Weight <= 0;

            if (isValidInput == true)
            {
                return "Invalid fish.";
            }
            else if (Fish.Count + 1 > Capacity)
            {
                return "Fish net is full.";
            }
            this.fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";

        }

        /// <summary>
        /// Removes a fish by given weight, if such exists return true, otherwise false.
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        public bool ReleaseFish(double weight)
        {
            var fish = this.fish.FirstOrDefault(e => e.Weight == weight);
            if (fish != null)
            {
                return this.fish.Remove(fish);
            }
            return false;
            //Another solution
            /*
            bool isRemove = false;

            for (int i = 0; i < Fish.Count; i++)
            {
                if (Fish[i].Weight == weight)
                {
                    isRemove = true;
                    Fish.Remove(Fish[i]);
                }
            }

            return isRemove;*/
        }

        /// <summary>
        /// Search and returns a fish by given fish type.
        /// </summary>
        /// <param name="fishType"></param>
        /// <returns></returns>
        public Fish GetFish(string fishType)
        {

            var fish = this.fish.FirstOrDefault(e => e.FishType == fishType);
            return fish;
            //Another solution
            /*var getFish = new Fish("", 0, 0);
            foreach (Fish item in Fish)
            {
                if (item.FishType == fishType)
                {
                    getFish = item;
                }
            }
            return getFish;*/

        }

        /// <summary>
        /// Search and returns the longest fish in the collection.
        /// </summary>
        /// <returns></returns>
        public Fish GetBiggestFish()
        {
            var longestFish = this.fish.Max(e => e.Length);
            var fish = this.fish.FirstOrDefault(e => e.Length == longestFish);
            return fish;

            //Another solution
            /*
            var getBiggestFish = new Fish("", 0, 0);

            List<Fish> oreder = Fish.OrderBy(l => l.Length).ToList();

            getBiggestFish = oreder.Last();

            return getBiggestFish;*/
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Into the {this.Material}:");

            var result = fish.OrderByDescending(l => l.Length).ToList();

            foreach (var item in result)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();

        }
    }
}
