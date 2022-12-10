using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    /// <summary>
    /// Check all of the fields and methods access modifiers. Print on the console all of the mistakes in format:
    /// </summary>
    /// <param name="className"></param>
    /// <returns></returns>
    public string AnalyzeAcessModifiers(string className)
    {
        Type classType = Type.GetType(className);
        FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        StringBuilder stb = new StringBuilder();

        foreach (var field in classFields)
        {
            stb.AppendLine($"{field.Name} must be private!");
        }

        foreach (var nonPublicMethod in classNonPublicMethods.Where(m => m.Name.StartsWith("get")))
        {
            stb.AppendLine($"{nonPublicMethod.Name} have to be public!");
        }

        foreach (var publicMethod in classPublicMethods.Where(m => m.Name.StartsWith("set")))
        {
            stb.AppendLine($"{publicMethod.Name} have to be private!");
        }

        return stb.ToString().Trim();
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

