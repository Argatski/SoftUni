using EDriveRent.Models.Contracts;
using EDriveRent.Utilities.Messages;
using System;

namespace EDriveRent.Models.Entities
{
    public abstract class User : IUser
    {
        private string fistName;
        private string lastName;
        private double rating;
        private string drivingLicenseNumber;
        private bool isBlocked;

        public User(string firstName, string lastName, string drivingLicenseNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.rating = 0;
            this.DrivingLicenseNumber = drivingLicenseNumber;
            this.isBlocked = false;
        }


        public string FirstName
        {
            get => this.fistName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.FirstNameNull);
                }
                this.fistName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.LastNameNull);
                }
            }
        }

        public double Rating => this.rating;

        public string DrivingLicenseNumber
        {
            get => this.drivingLicenseNumber;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.DrivingLicenseRequired);
                }
            }
        }


        public bool IsBlocked => this.isBlocked;

        public void DecreaseRating()
        {
            if (this.rating < 2.0)
            {
                this.rating = 0.0;
                this.isBlocked = true;
            }
            else
            {
                this.rating -= 2.0;
            }
        }

        public void IncreaseRating()
        {
            if (this.rating < 10.0)
            {
                this.rating += 0.5;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} Driving license: {this.DrivingLicenseNumber} Rating: {this.Rating}";
        }
    }
}
