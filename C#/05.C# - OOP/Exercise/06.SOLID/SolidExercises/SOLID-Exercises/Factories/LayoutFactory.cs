using SOLID_Exercises.Exceptions;
using SOLID_Exercises.Factories.Contracts;
using SOLID_Exercises.Models.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace SOLID_Exercises.Factories
{
    public class LayoutFactory : ILayoutFactory
    {
        public ILayout GetLayout(string type)
        {
            var typeToCreate = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == type);

            if (typeToCreate == null)
            {
                throw new InvalidLayoutTypeException();
            }

            ILayout layout = (ILayout)Activator.CreateInstance(typeToCreate);

            return layout;
        }
    }
}
