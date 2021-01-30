using System;
using System.Linq;
using System.Reflection;

namespace DIDemo
{
    public class DependencyResolver
    {
        DependencyContainer _container;

        public DependencyResolver(DependencyContainer container)
        {
            _container = container;
        }

        public T GetService<T>()
        {
            return (T)GetService(typeof(T));
        }

        private object GetService(Type type)
        {
            var dependency = _container.GetDependency(type);
            var construtor = dependency.GetConstructors().Single();
            var parameters = construtor.GetParameters().ToArray();

            if(parameters.Length > 0)
            {
                var paramDependencies = new Object[parameters.Length];
                for (int i = 0; i < parameters.Length; i++)
                {
                    paramDependencies[i] = Activator.CreateInstance(parameters[i].ParameterType);
                }
                return Activator.CreateInstance(dependency, paramDependencies);
            }

            return Activator.CreateInstance(dependency);
        }
    }
}
