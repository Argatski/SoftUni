namespace SoftUniDiFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Field)]
    internal class Inject : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field)]
    public class Named : Attribute
    {
        public Named(string name)
        {
            this.Name = name;
        }
        public string Name { get; }
    }
}
