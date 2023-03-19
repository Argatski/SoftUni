using SoftUniDiFramework.Attributes;
using System.Reflection.Metadata;

namespace SoftUniDiFramework.Modules
{
    public abstract class AbstractModule : IModule
    {
        private IDictionary<Type, Dictionary<string, Type>> implementations;
        private IDictionary<Type, object> instances;

        public AbstractModule()
        {
            this.implementations = new Dictionary<Type, Dictionary<string, Type>>();
            this.instances = new Dictionary<Type, object>();
        }

        public abstract void Configure();

        protected void CreateMapping<TInter, TImpl>()
        {
            if (this.implementations.ContainsKey(typeof(TImpl)) == false)
            {
                this.implementations[typeof(TImpl)] = new Dictionary<string, Type>();
            }
            this.implementations[typeof(TInter)].Add(typeof(TImpl).Name, typeof(TImpl));
        }

        public Type GetMapping(Type currentInterface, object attribute)
        {
            var currentInmplementation = this.implementations[currentInterface];

            Type type = null;

            if (attribute is Inject)
            {
                if (this.implementations.Count == 1)
                {
                    type = currentInmplementation.Values.First();
                }
                else
                {
                    throw new ArgumentException("No available mapping for class: " + currentInterface.FullName);
                }
            }
            else if (attribute is Named)
            {
                Named named = attribute as Named;

                string dependencyName = named.Name;
                type = currentInmplementation[dependencyName];

            }

            return type;
        }
        public void SetInstance(Type implementation, object instance)
        {
            if (this.instances.ContainsKey(implementation) == false)
            {
                this.instances.Add(implementation, instance);
            }
        }
        public object GetInstance(Type implementation)
        {
            this.instances.TryGetValue(implementation, out object value);

            return value;
        }
    }
}
