using System.Text;

namespace Minedraft.Models.Providers
{
    public abstract class Provider : Machine
    {
        private double energyOutput;
        protected Provider(string id, double energyOutput)
            : base(id)
        {
            this.EnergyOutput = energyOutput;
        }
        public double EnergyOutput
        {
            get { return this.energyOutput; }
            protected set
            {
                Validator.Validator.CheckProviderEnerygOutput(nameof(EnergyOutput), value);
                this.energyOutput = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Energy Output: {this.EnergyOutput}");
            return sb.ToString();
        }
    }
}
