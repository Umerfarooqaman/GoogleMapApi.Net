using System;
using System.Collections.Generic;
using System.Text;


namespace Utility
{
    public class InstanceManager<T>
    {
        private static readonly Dictionary<string, T> pool = new Dictionary<string, T>();

        public static T GetInstance()
        {
            return (T)Activator.CreateInstance(typeof(T)); ;
        }

        public static T GetScopedInstance(string scope)
        {
            if (pool.ContainsKey(scope))
            {
                pool.TryGetValue(scope, value: out var service);

                return service;
            }
            else
            {
                T service;
                pool.Add(scope, service = GetInstance());

                return service;
            }
        }

        public static T GetSingletonInstance()
        {
            return GetScopedInstance("singelton");
        }

    }
}
