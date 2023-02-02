using System.Text;

namespace Minedraft.Models.Harvesters
{
    public abstract class Harvester : Machine
    {
        private double oreOutput;
        private double energyRequirement;

        protected Harvester(string id, double oreOutput, double energyrequirement)
            : base(id)
        {
            this.OreOutput = oreOutput;
            this.EnergyRequirement = energyrequirement;
        }

        public double OreOutput
        {
            get { return this.oreOutput; }
            protected set
            {
                Validator.Validator.CheckHarvesterOreOuput(nameof(this.OreOutput), value);
                this.oreOutput = value;
            }
        }
        public double EnergyRequirement
        {
            get { return this.energyRequirement; }
            protected set
            {
                Validator.Validator.CheckHarvesterEnergyRequirement(nameof(this.EnergyRequirement), value);
                this.energyRequirement = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine($"Ore Output: {this.OreOutput}");
            stb.Append($"Energy Requirement: {this.EnergyRequirement}");
            return stb.ToString();
        }
    }
}
