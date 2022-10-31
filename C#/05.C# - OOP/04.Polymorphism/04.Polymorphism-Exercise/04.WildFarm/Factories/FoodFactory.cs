using System;
using System.Linq;
using System.Reflection;
using WildFarm.Common;
using WildFarm.Core;

namespace WildFarm.Factories
{
    public class FoodFactory
    {
        public Food Create(string strType, int quantity)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type type = assembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == strType);

            if (type == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidType);
            }

            object[] ctorParams = new object[] { quantity };
            Food food = (Food)Activator.CreateInstance(type, ctorParams);

            return food;
        }
    }
}
