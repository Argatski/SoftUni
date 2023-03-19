using SoftUniDiFramework.Injectors;
using SoftUniDiFramework.Modules;

internal class Program
{
    private static void Main(string[] args)
    {
       
    }
    public static Injector CreateInjector(IModule module)
    {
        module.Configure();
        return new Injector(module);
    }
}