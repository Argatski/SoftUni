using System.Runtime.Serialization.Formatters.Binary;

namespace _08.Prototype
{
    [Serializable]
    public class Country : ICloneable
    {
        public string Name { get; set; }

        public object Clone() 
        {
            return this.MemberwiseClone();
        }

        public static T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
    }
}