using GrandPrix.Exception;
using System;

namespace GrandPrix.Models.Tyres
{
    public class UltrasoftTyre : Tyre
    {
        private const double MinDegradation = 30;
        private double degradation;
        private double grip;
        public UltrasoftTyre(string name, double hardness)
            : base(name, hardness)
        {
            this.Grip = this.grip;
        }
        public double Grip
        {
            get { return this.grip; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input");
                }
                this.grip = value;
            }
        }

        public override double Degradation
        {
            get { return this.degradation; }
            protected set
            {
                if (value < MinDegradation)
                {
                    throw new ArgumentException(ErroMessage.TyreDegradation);
                }
                this.degradation = value;
            }
        }
        public override void ReduceDegradation()
        {
            this.Degradation -= this.Grip + this.Hardness;
        }
    }
}
