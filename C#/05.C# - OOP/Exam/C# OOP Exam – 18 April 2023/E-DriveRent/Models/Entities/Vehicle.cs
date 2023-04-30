using EDriveRent.Models.Contracts;
using EDriveRent.Utilities.Messages;
using System;

namespace EDriveRent.Models.Entities
{
    public abstract class Vehicle : IVehicle
    {
        private string brad;
        private string model;
        private double maxMileage;
        private string licensePlateNumber;
        private int batteryLevel;
        private bool isDamaged;

        public Vehicle(string brand, string model, double maxMileage, string licensePlateNumber)
        {
            Brand = brand;
            Model = model;
            this.maxMileage = maxMileage;
            LicensePlateNumber = licensePlateNumber;
            batteryLevel = 100;
            isDamaged = false;
        }

        public string Brand
        {
            get => brad;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.BrandNull);
                }
                brad = value;
            }
        }

        public string Model
        {
            get => model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ModelNull);
                }
                model = value;
            }
        }


        public double MaxMileage => maxMileage;

        public string LicensePlateNumber
        {
            get => licensePlateNumber;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.LicenceNumberRequired);
                }
            }
        }

        public int BatteryLevel => batteryLevel;

        public bool IsDamaged => isDamaged;

        public void ChangeStatus()
        {
            if (IsDamaged == false)
            {
                isDamaged = true;
            }
            else
            {
                isDamaged = false;
            }
        }

        public void Drive(double mileage)
        {
            double percntage = Math.Round(mileage / maxMileage * 100);
            batteryLevel -= (int)percntage;

            if (GetType().Name == nameof(CargoVan))
            {
                batteryLevel -= 5;
            }
        }

        public void Recharge()
        {
            batteryLevel = 100;
        }

        public override string ToString()
        {
            string vehicleCondition;
            if (isDamaged)
            {
                vehicleCondition = "damaged";
            }
            else
            {
                vehicleCondition = "ok";
            }
            return $"{Brand} {Model} License plate: {LicensePlateNumber} Battery: {BatteryLevel}% Status: {vehicleCondition}";
        }
    }
}
