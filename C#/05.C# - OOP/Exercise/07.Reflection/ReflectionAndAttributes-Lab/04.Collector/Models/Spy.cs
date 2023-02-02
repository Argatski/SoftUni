using System;
using System.Linq;
using System.Reflection;
using System.Text;


public class Spy
{
    public string CollectGettersAndSetters(string investigateClass)
    {
        Type clasType = Type.GetType(investigateClass);

        MethodInfo[] classMethods = clasType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        StringBuilder stb = new StringBuilder();

        foreach (var method in classMethods.Where(m => m.Name.StartsWith("get")))
        {
            stb.AppendLine($"{method.Name} will return {method.ReturnType}");
        }
        foreach (var method in classMethods.Where(m => m.Name.StartsWith("set")))
        {
            stb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
        }

        return stb.ToString().Trim();
    }
}
