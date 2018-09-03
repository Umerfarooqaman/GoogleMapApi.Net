using System;
using System.Collections.Generic;

namespace GoogleMapServices
{
    public class InstanceManager<T>
    {
        public static readonly Dictionary<string, T> Pool = new Dictionary<string, T>();

        public static T GetInstance()
        {
            return (T)Activator.CreateInstance(typeof(T)); ;
        }

        public static T GetScopedInstance(string scope)
        {
            if (Pool.ContainsKey(scope))
            {
                Pool.TryGetValue(scope, value: out var service);

                return service;
            }
            else
            {
                T service;
                Pool.Add(scope, service = GetInstance());

                return service;
            }
        }

        public static T GetSingletonInstance()
        {
            return GetScopedInstance("singelton");
        }

    }
}
