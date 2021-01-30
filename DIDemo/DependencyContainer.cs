using System;
using System.Collections.Generic;
using System.Linq;

namespace DIDemo
{
   public class DependencyContainer
    {
        List<Type> _dependencies = new List<Type>();

        public void AddDependencies<T>()
        {
            _dependencies.Add(typeof(T));
        }

        public Type GetDependency(Type type)
        {
            return _dependencies.First(dp => dp.Name == type.Name);
        }
    }
}
