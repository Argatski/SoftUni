using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
        {
            Type classType = Type.GetType(investigatedClass);
            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

            StringBuilder stb = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            stb.AppendLine($"Class under investigation: {investigatedClass}");

            foreach (var field in classFields.Where(f => requestedFields.Contains(f.Name)))
            {
                stb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return stb.ToString().Trim();
        }
    }
}
