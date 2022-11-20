using System.Text;

namespace Minedraft.Models.Harvesters
{
    public class HammerHarvester : Harvester
    {
        private const int IncreaseOreOutput = 200;
        private const int IncreaseEnergyRequirement = 100;
        public HammerHarvester(string id, double oreOutput, double energyrequirement)
            : base(id, oreOutput, energyrequirement)
        {
            this.OreOutput = oreOutput + (oreOutput * IncreaseOreOutput / 100);
            this.EnergyRequirement = energyrequirement + (energyrequirement * IncreaseEnergyRequirement / 100);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Hammer Harvester - {this.Id}");
            sb.Append(base.ToString());
            return sb.ToString();
        }
    }
}
