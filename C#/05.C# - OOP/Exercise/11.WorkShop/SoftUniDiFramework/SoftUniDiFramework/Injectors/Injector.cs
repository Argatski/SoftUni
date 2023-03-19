using SoftUniDiFramework.Attributes;
using SoftUniDiFramework.Modules;
using System.Formats.Asn1;
using System.Reflection;

namespace SoftUniDiFramework.Injectors
{
    internal class Injector
    {
        private IModule module;
        public Injector(IModule module)
        {
            this.module = module;
        }

        private bool CheckForFieldInjection<TClass>()
        {
            return typeof(TClass)
                .GetFields((BindingFlags)62)
                .Any(field => field.GetCustomAttributes(typeof(Inject), true).Any());
        }

        private bool CheckForConstructorInjection<TClass>()
        {
            return typeof(TClass).GetConstructors()
                .Any(consturctor => consturctor.GetCustomAttributes(typeof(Inject), true).Any());
        }
        private TClass CreateConstructorInjection<TClass>()
        {
            var desireClass = typeof(TClass);

            if (desireClass == null) return default(TClass);

            var constructors = desireClass.GetConstructors();
            foreach (var constructor in constructors)
            {
                if (CheckForConstructorInjection<TClass>())
                {
                    continue;
                }

                var inject = (Inject)constructor
                    .GetCustomAttributes(typeof(Inject), true)
                    .FirstOrDefault();

                var parameterTypes = constructor.GetParameters();

                var constructorParames = new object[parameterTypes.Length];

                var i = 0;
                foreach (var parameterType in parameterTypes)
                {
                    //TODO .............
                    var named = parameterType.GetCustomAttribute(typeof(Named));
                    Type dependecy = null;

                    if (named == null)
                    {
                        dependecy = this.module.GetMapping(parameterType.ParameterType, inject);
                    }
                    else
                    {
                        dependecy = this.module.GetMapping(parameterType.ParameterType, named);
                    }

                    if (parameterType.ParameterType.IsAssignableFrom(dependecy))
                    {
                        object instance = this.module.GetInstance(dependecy);
                        if (instance != null)
                        {
                            constructorParames[i++] = instance;
                        }
                        else
                        {
                            instance = Activator.CreateInstance(dependecy);
                            constructorParames[i++] = instance;

                            this.module.SetInstance(parameterType.ParameterType, instance);
                        }
                        return (TClass)Activator.CreateInstance(desireClass, constructorParames);
                    }
                }
            }

            return default(TClass);
        }

        private TClass CreateFieldInjection<TClass>()
        {
            var desireClass = typeof(TClass);
            var desireClassInstance = this.module.GetInstance(desireClass);

            if (desireClassInstance != null)
            {
                desireClassInstance = Activator.CreateInstance(desireClass);
                this.module.SetInstance(desireClass, desireClassInstance);
            }

            var fields = desireClass.GetFields((BindingFlags)62);

            foreach (var field in fields)
            {
                if (field.GetCustomAttributes(typeof(Inject), true).Any())
                {
                    var injection = (Inject)field.GetCustomAttributes(typeof(Inject), true)
                        .FirstOrDefault();

                    Type dependecy = null;

                    var named = field.GetCustomAttribute(typeof(Inject), true);

                    var type = field.FieldType;

                    if (named == null)
                    {
                        dependecy = this.module.GetMapping(type, injection);
                    }
                    else
                    {
                        dependecy = this.module.GetMapping(type, named);

                        if (type.IsAssignableFrom(dependecy))
                        {
                            object instance = this.module.GetInstance(dependecy);
                            if (instance == null)
                            {
                                instance = Activator.CreateInstance(dependecy);
                                this.module.SetInstance(dependecy, instance);
                            }
                            field.SetValue(instance, dependecy);
                        }
                    }
                }
            }
            return (TClass)desireClassInstance;
        }

        public TClass Inject<TClass>()
        {
            var hasConstructorAttribute = this.CheckForConstructorInjection<TClass>();

            var hasFieldAttribute = this.CheckForFieldInjection<TClass>();

            if (hasConstructorAttribute && hasFieldAttribute)
            {
                throw new ArgumentException("There  must be only field or constructor annotated with Inject attribute");
            }
            if (hasConstructorAttribute)
            {
                return this.CreateConstructorInjection<TClass>();

            }
            else if (hasFieldAttribute)
            {
                return this.CreateFieldInjection<TClass>();
            }
            return default(TClass);
        }
    }
}
