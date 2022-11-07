using GrandPrix.Exception;
using GrandPrix.Models.Tyres.Contract;
using System;

namespace GrandPrix.Models.Tyres
{
    public abstract class Tyre : ITyre
    {
        private double startPointDegradation = 100;
        private string name;
        private double hardness;
        private double degradation;

        public Tyre(string name, double hardness)
        {
            this.Name = name;
            this.Hardness = hardness;
            this.Degradation = degradation;
        }
        public string Name { get { return this.name; } private set { this.name = value; } }

        public double Hardness { get {return this.hardness; } private set { this.hardness = value; } }

        public virtual double Degradation
        {
            get { return this.startPointDegradation; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ErroMessage.TyreDegradation);
                }
                this.degradation = value;
            }
        }
        public virtual void ReduceDegradation()
        {
            this.Degradation -= this.Hardness;
        }

    }
}
