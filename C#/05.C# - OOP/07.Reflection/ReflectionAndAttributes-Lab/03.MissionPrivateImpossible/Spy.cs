using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string RevealPrivateMethods(string investigatedClass)
    {
        Type classType = Type.GetType(investigatedClass);
        MethodInfo[] classMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        StringBuilder stb = new StringBuilder();

        stb.AppendLine($"All Private Methods of Class: {investigatedClass}");
        stb.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (var method in classMethods)
        {
            stb.AppendLine(method.Name);
        }
        return stb.ToString().Trim();
    }
    public string AnalyzeAcessModifiers(string className)
    {
        Type classType = Type.GetType(className);
        FieldInfo[] fieldInfos = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        MethodInfo[] methodInfos = classType.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

        StringBuilder sb = new StringBuilder();
        foreach (FieldInfo field in fieldInfos)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }
        foreach (MethodInfo method in methodInfos.Where(m => m.Name.StartsWith("get") && m.IsPrivate))
        {
            sb.AppendLine($"{method.Name} have to be public!");
        }
        foreach (MethodInfo method in methodInfos.Where(m => m.Name.StartsWith("set") && m.IsPublic))
        {
            sb.AppendLine($"{method.Name} have to be private!");
        }

        return sb.ToString().Trim();
    }

    public string StealFieldInfo(string className, params string[] fieldsNames)
    {
        Type classType = Type.GetType(className);
        FieldInfo[] fieldInfos = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Class under investigation: {className}");

        Object instance = Activator.CreateInstance(classType, new object[] { });
        foreach (FieldInfo field in fieldInfos)
        {
            foreach (string name in fieldsNames)
            {
                if (field.Name == name)
                {
                    sb.AppendLine($"{field.Name} = {field.GetValue(instance)}");
                }
            }
        }

        return sb.ToString().Trim();
    }
}

