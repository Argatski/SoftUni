namespace Minedraft.Models.Providers
{
    public class PressureProvider : Providers
    {
        private const double IncreaseEnergyOutput = 50;
        public PressureProvider(string id, double energyOutput)
            : base(id, energyOutput)
        {
            this.EnergyOutput = energyOutput + (energyOutput * IncreaseEnergyOutput / 100);
        }
    }
}
