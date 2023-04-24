using ChristmasPastryShop.Core.Contracts;
using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Booths.Entity;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Cocktails.Entity;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Models.Delicacies.Entity;
using ChristmasPastryShop.Repositories.Contracts;
using ChristmasPastryShop.Repositories.Entity;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristmasPastryShop.Core
{
    public class Controller : IController
    {
        private IRepository<IBooth> booths;

        public Controller()
        {
            booths = new BoothRepository();
        }

        public string AddBooth(int capacity)
        {
            int boothId = booths.Models.Count + 1;
            Booth booth = new Booth(boothId, capacity);

            booths.AddModel(booth);

            return string.Format(OutputMessages.NewBoothAdded, boothId, capacity);
        }

        public string AddCocktail(int boothId, string cocktailTypeName, string cocktailName, string size)
        {
            if (cocktailTypeName != nameof(Hibernation) && cocktailTypeName != nameof(MulledWine))
            {
                return string.Format(OutputMessages.InvalidCocktailType, cocktailTypeName);
            }
            if (size != "Small" && size != "Middle" && size != "Large")
            {
                return string.Format(OutputMessages.InvalidCocktailSize, size);
            }
            if (booths.Models.Any(b => b.CocktailMenu.Models.Any(cm => cm.Name == cocktailName && cm.Size == size)))
            {
                return string.Format(OutputMessages.CocktailAlreadyAdded, size, cocktailName);
            }

            ICocktail cocktail;
            if (cocktailTypeName == nameof(Hibernation))
            {
                cocktail = new Hibernation(cocktailName, size);
            }
            else
            {
                cocktail = new MulledWine(cocktailName, size);
            }

            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);

            booth.CocktailMenu.AddModel(cocktail);

            return string.Format(OutputMessages.NewCocktailAdded, size, cocktailName, cocktailTypeName);

        }

        public string AddDelicacy(int boothId, string delicacyTypeName, string delicacyName)
        {
            if (delicacyTypeName != nameof(Gingerbread) && delicacyTypeName != nameof(Stolen))
            {
                return string.Format(OutputMessages.InvalidDelicacyType, delicacyTypeName);
            }
            if (booths.Models.Any(d => d.DelicacyMenu.Models.Any(dm => dm.Name == delicacyName)))
            {
                return string.Format(OutputMessages.DelicacyAlreadyAdded, delicacyName);
            }

            IDelicacy delicacy;
            if (delicacyTypeName == nameof(Gingerbread))
            {
                delicacy = new Gingerbread(delicacyName);
            }
            else
            {
                delicacy = new Stolen(delicacyName);
            }

            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);

            booth.DelicacyMenu.AddModel(delicacy);

            return string.Format(OutputMessages.NewDelicacyAdded, delicacyTypeName, delicacyName);
        }

        public string BoothReport(int boothId)
        {
            return booths.Models.FirstOrDefault(b => b.BoothId == boothId).ToString().TrimEnd();
        }

        public string LeaveBooth(int boothId)
        {
            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);

            StringBuilder stb = new StringBuilder();
            stb.AppendLine($"Bill {booth.CurrentBill:f2} lv");

            booth.Charge();
            booth.ChangeStatus();

            stb.AppendLine($"Booth {boothId} is now available!");

            return stb.ToString().TrimEnd();
        }

        public string ReserveBooth(int countOfPeople)
        {
            var booth = booths.Models
                .Where(b => b.IsReserved == false && b.Capacity >= countOfPeople)
                .OrderBy(b => b.Capacity)
                .ThenByDescending(b => b.BoothId)
                .FirstOrDefault();

            if (booth == null)
            {
                return string.Format(OutputMessages.NoAvailableBooth, countOfPeople);
            }

            booth.ChangeStatus();

            return string.Format(OutputMessages.BoothReservedSuccessfully, booth.BoothId, countOfPeople);
        }

        public string TryOrder(int boothId, string order)
        {
            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);

            string[] orederArray = order.Split('/');
            bool isCoctail = false;

            string typeName = orederArray[0];
            if (typeName != nameof(MulledWine) && typeName != nameof(Hibernation) && typeName != nameof(Gingerbread) && typeName != nameof(Stolen))
            {
                return
                    string.Format(OutputMessages.NotRecognizedType, typeName);
            }

            string name = orederArray[1];

            if (!booth.CocktailMenu.Models.Any(c => c.Name == name) &&
            !booth.DelicacyMenu.Models.Any(d => d.Name == name))
            {
                return string.Format(OutputMessages.NotRecognizedItemName, typeName, name);
            }

            int pieces = int.Parse(orederArray[2]);

            if (typeName == nameof(MulledWine) ||
                typeName == nameof(Hibernation))
            {
                isCoctail = true;
            }

            if (isCoctail)
            {
                string size = orederArray[3];

                ICocktail desiredCocktail = booth
                    .CocktailMenu.Models
                    .FirstOrDefault(m => m.GetType().Name == typeName && m.Name == name && m.Size == size);

                if (desiredCocktail == null)
                {
                    return string.Format(OutputMessages.CocktailStillNotAdded, size, name);
                }
                booth.UpdateCurrentBill(desiredCocktail.Price * pieces);
                return string.Format(OutputMessages.SuccessfullyOrdered, boothId, pieces, name);
            }
            else
            {
                IDelicacy desiredDelicacy = booth.DelicacyMenu.Models.FirstOrDefault(d => d.GetType().Name == typeName && d.Name == name);

                if (desiredDelicacy == null)
                {
                    return string.Format(OutputMessages.DelicacyStillNotAdded, typeName, name);
                }

                booth.UpdateCurrentBill(desiredDelicacy.Price * pieces);

                return string.Format(OutputMessages.SuccessfullyOrdered, boothId, pieces, name);
            }


        }
    }
}
