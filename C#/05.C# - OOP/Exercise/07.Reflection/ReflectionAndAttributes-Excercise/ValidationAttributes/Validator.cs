using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    using System.Linq;
    using ValidationAttributes.Attributes;
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            var propertyInfo = obj.GetType()
                .GetProperties();

            foreach (var property in propertyInfo)
            {
                var attributes = property
                    .GetCustomAttributes(true)
                    .Where(a => a is MyValidationAttribute)
                    .Cast<MyValidationAttribute>()
                    .ToArray();

                foreach (var att in attributes)
                {
                    if (att.IsValid(property.GetValue(obj)) == false)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
