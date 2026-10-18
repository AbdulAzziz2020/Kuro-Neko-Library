using System;
using System.Collections.Generic;
using UnityEngine;

namespace KuroNeko.Library
{
    [Serializable]
    public class ServiceLocator : MonoBehaviour
    {
        private static readonly Dictionary<Type, object> services = new();

        public static void Register<T>(T service, bool @override = false) where T : class
        {
            if(service == null) 
                throw new ArgumentNullException(nameof(service));
            
            Type type = typeof(T);
            if (services.ContainsKey(type) && !@override)
                throw new ArgumentException($"Service of type {type.Name} already registered.");
            
            services[type] = service;
            Debug.Log($"Registered service {type.Name}");
        }

        public static T Get<T>() where T : class
        {
            if (!services.ContainsKey(typeof(T)))
                throw new ArgumentException($"Service of type {typeof(T).Name} not registered.");
            
            return (T) services[typeof(T)];
        }

        public static bool TryResolve<T>(out T service) where T : class
        {
            if (services.TryGetValue(typeof(T), out object @object))
            {
                service = (T) @object;
                return true;
            }

            service = null;
            return false;
        }

        public static bool Remove<T>() where T : class
        {
            return services.Remove(typeof(T));
        }

        public static bool Remove<T>(T service) where T : class
        {
            return services.Remove(typeof(T));
        }

        public static void Clear()
        {
            services.Clear();
        }
    }
}