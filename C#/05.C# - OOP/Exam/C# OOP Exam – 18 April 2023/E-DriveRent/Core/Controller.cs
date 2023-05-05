using EDriveRent.Core.Contracts;
using EDriveRent.Models.Contracts;
using EDriveRent.Models.Entities;
using EDriveRent.Repositories.Contracts;
using EDriveRent.Repositories.Entities;
using EDriveRent.Utilities.Messages;
using System.Linq;
using System.Text;

namespace EDriveRent.Core
{
    public class Controller : IController
    {
        private IRepository<IUser> users;
        private IRepository<IVehicle> vehicles;
        private IRepository<IRoute> routes;

        public Controller()
        {
            this.users = new UserRepository();
            this.vehicles = new VehicleRepository();
            this.routes = new RouteRepository();
        }

        public string AllowRoute(string startPoint, string endPoint, double length)
        {
            int routeId = this.routes.GetAll().Count + 1;
            IRoute existingRoute = this.routes
                .GetAll()
                .FirstOrDefault(r => r.StartPoint == startPoint && r.EndPoint == endPoint);

            if (existingRoute != null)
            {
                if (existingRoute.Length == length)
                {
                    return string.Format(OutputMessages.RouteExisting, startPoint, endPoint, length);
                }
                else if (existingRoute.Length < length)
                {
                    return string.Format(OutputMessages.RouteIsTooLong, startPoint, endPoint);
                }
                else if (existingRoute.Length > length)
                {
                    existingRoute.LockRoute();
                }
            }

            IRoute newRoute = new Route(startPoint, endPoint, length, routeId);

            routes.AddModel(newRoute);

            return string.Format(OutputMessages.NewRouteAdded, startPoint, endPoint, length);

        }

        public string MakeTrip(string drivingLicenseNumber, string licensePlateNumber, string routeId, bool isAccidentHappened)
        {
            IUser user = this.users.FindById(drivingLicenseNumber);
            IVehicle vehicle = this.vehicles.FindById(licensePlateNumber);
            IRoute route = this.routes.FindById(routeId);

            if (user.IsBlocked)
            {
                return string.Format(OutputMessages.UserBlocked, drivingLicenseNumber);
            }
            if (vehicle.IsDamaged)
            {
                return string.Format(OutputMessages.VehicleDamaged, licensePlateNumber);
            }
            if (route.IsLocked)
            {
                return string.Format(OutputMessages.RouteLocked, routeId);
            }

            vehicle.Drive(route.Length);

            if (isAccidentHappened)
            {
                vehicle.ChangeStatus();
                user.DecreaseRating();
            }
            else
            {
                user.IncreaseRating();
            }
            return vehicle.ToString();
        }


        public string RegisterUser(string firstName, string lastName, string drivingLicenseNumber)
        {
            IUser user = this.users.FindById(drivingLicenseNumber);

            if (user != null)
            {
                return string.Format(OutputMessages.UserWithSameLicenseAlreadyAdded, drivingLicenseNumber);
            }

            user = new User(firstName, lastName, drivingLicenseNumber);

            this.users.AddModel(user);

            return string.Format(OutputMessages.UserSuccessfullyAdded, firstName, lastName, drivingLicenseNumber);

        }

        public string RepairVehicles(int count)
        {
            var damagedVehicle = this.vehicles.GetAll().Where(v => v.IsDamaged == true).OrderBy(v => v.Brand).ThenBy(v => v.Model);

            int vehiclesCount = 0;

            if (damagedVehicle.Count() < vehiclesCount)
            {
                vehiclesCount = damagedVehicle.Count();
            }
            else
            {
                vehiclesCount = count;
            }

            var selectedVehicles = damagedVehicle.ToArray().Take(vehiclesCount);

            foreach (var vehic in selectedVehicles)
            {
                vehic.ChangeStatus();
                vehic.Recharge();
            }

            return string.Format(OutputMessages.RepairedVehicles, vehiclesCount);
        }

        public string UploadVehicle(string vehicleType, string brand, string model, string licensePlateNumber)
        {
            if (vehicleType != nameof(PassengerCar) && vehicleType != nameof(CargoVan))
            {
                return string.Format(OutputMessages.VehicleTypeNotAccessible, vehicleType);
            }

            IVehicle vehicle = vehicles.FindById(licensePlateNumber);

            if (vehicle != null)
            {
                return string.Format(OutputMessages.VehicleTypeNotAccessible, vehicleType);
            }
            else
            {
                if (vehicleType == nameof(PassengerCar))
                {
                    vehicle = new PassengerCar(brand, model, licensePlateNumber);
                }
                else if (vehicleType == nameof(CargoVan))
                {
                    vehicle = new CargoVan(brand, model, licensePlateNumber);
                }
            }


            vehicles.AddModel(vehicle);
            return string.Format(OutputMessages.VehicleAddedSuccessfully, brand, model, licensePlateNumber);
        }

        public string UsersReport()
        {
            StringBuilder stb = new StringBuilder();

            stb.AppendLine($"*** E-Drive-Rent ***");

            foreach (var user in this.users.GetAll().OrderByDescending(u => u.Rating).ThenBy(u => u.LastName).ThenBy(u => u.FirstName))
            {
                stb.AppendLine(user.ToString());
            }

            return stb.ToString();
        }
    }
}
