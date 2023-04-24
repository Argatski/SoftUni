using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using ChristmasPastryShop.Repositories.Entity;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Text;

namespace ChristmasPastryShop.Models.Booths.Entity
{
    public abstract class Booth : IBooth
    {
        private int boothId;
        private int capacty;
        private double currentBill;
        private double turnover;

        private readonly IRepository<IDelicacy> delicacies;
        private readonly IRepository<ICocktail> cocktails;


        public Booth(int boothId, int capacity)
        {
            this.BoothId = boothId;
            this.Capacity = capacity;

            this.delicacies = new DelicacyRepository();
            this.cocktails = new CocktailRepository();

            this.currentBill = 0;
            this.turnover = 0;
        }
        public int BoothId
        {
            get { return boothId; }
            private set { this.boothId = value; }
        }

        public int Capacity
        {
            get { return capacty; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException(ExceptionMessages.CapacityLessThanOne);
                }
                this.capacty = value;
            }
        }
        public IRepository<IDelicacy> DelicacyMenu => this.delicacies;

        public IRepository<ICocktail> CocktailMenu => this.cocktails;

        public double CurrentBill => this.currentBill;

        public double Turnover => this.turnover;

        public bool IsReserved
        {
            get;
            private set;
        }


        public void ChangeStatus()
        {
            if (IsReserved)
            {
                IsReserved = false;
                return;
            }
            IsReserved = true;
        }

        public void Charge()
        {
            this.turnover += currentBill;
            this.currentBill = 0;
        }

        public void UpdateCurrentBill(double amount)
        {
            this.currentBill += amount;

        }

        public override string ToString()
        {

            StringBuilder strb = new StringBuilder();

            strb.AppendLine($"BoothId: {this.BoothId}");
            strb.AppendLine($"Capacity: {this.Capacity}");
            strb.AppendLine($"Turnover: {this.Turnover:f2}");

            strb.AppendLine($"Coktail menu:");

            foreach (var coctail in CocktailMenu.Models)
            {
                strb.AppendLine($"--{coctail}");
            }


            strb.AppendLine($"Delicacy menu:");

            foreach (var delicacy in DelicacyMenu.Models)
            {
                strb.AppendLine($"--{delicacy}");
            }

            return strb.ToString().TrimEnd();
        }
    }
}
