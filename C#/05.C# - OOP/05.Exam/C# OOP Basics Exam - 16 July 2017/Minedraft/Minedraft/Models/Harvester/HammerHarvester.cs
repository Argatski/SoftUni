namespace Minedraft.Models.Harvester
{
    public class HammerHarvester : Harverster
    {
        private const int IncreaseOreOutput = 200;
        private const int IncreaseEnergyRequirement = 100;
        public HammerHarvester(string id, double oreOutput, double energyrequirement)
            : base(id, oreOutput, energyrequirement)
        {
            this.OreOutput = oreOutput + (oreOutput * IncreaseOreOutput / 100);
            this.EnergyRequirement = energyrequirement + (energyrequirement * IncreaseEnergyRequirement / 100);
        }

    }
}
