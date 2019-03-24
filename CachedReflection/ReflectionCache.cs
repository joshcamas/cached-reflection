using System.Reflection;
using System.Collections.Generic;
using System;

namespace Ardenfall.Reflection
{
    /// <summary>
    /// Caches type's reflected fields, methods, and properties.
    /// </summary>
    public static class ReflectionCache
    {
        private static Dictionary<Type, CachedReflectionType> cache;

        public static FieldInfo[] GetFields(Type type)
        {
            return GetReflectedType(type).GetFields();
        }

        public static MethodInfo[] GetMethods(Type type)
        {
            return GetReflectedType(type).GetMethods();
        }

        public static FieldInfo GetField(Type type,string field)
        {
            return GetReflectedType(type).GetField(field);
        }

        public static MethodInfo GetMethod(Type type, string method)
        {
            return GetReflectedType(type).GetMethod(method);
        }

        public static PropertyInfo GetProperty(Type type, string property)
        {
            return GetReflectedType(type).GetProperty(property);
        }

        private static CachedReflectionType GetReflectedType(Type type)
        {
            if (cache == null)
                cache = new Dictionary<Type, CachedReflectionType>();

            if (!cache.ContainsKey(type))
                cache.Add(type, new CachedReflectionType(type));

            return cache[type];
        }

    }
}