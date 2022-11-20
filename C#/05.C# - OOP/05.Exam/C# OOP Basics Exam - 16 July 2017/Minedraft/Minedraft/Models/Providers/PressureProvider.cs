﻿using System.Text;

namespace Minedraft.Models.Providers
{
    public class PressureProvider : Provider
    {
        private const double IncreaseEnergyOutput = 50;
        public PressureProvider(string id, double energyOutput)
            : base(id, energyOutput)
        {
            this.EnergyOutput = energyOutput + (energyOutput * IncreaseEnergyOutput / 100);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pressure Provider - {this.Id}");
            sb.Append(base.ToString());
            return sb.ToString();
        }
    }
}
