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

        public static FieldInfo GetField(Type type,string field)
        {
            if (cache == null)
                cache = new Dictionary<Type, CachedReflectionType>();

            if (!cache.ContainsKey(type))
                cache.Add(type, new CachedReflectionType(type));

            return cache[type].GetField(field);
        }

        public static MethodInfo GetMethod(Type type, string field)
        {
            if (cache == null)
                cache = new Dictionary<Type, CachedReflectionType>();

            if (!cache.ContainsKey(type))
                cache.Add(type, new CachedReflectionType(type));

            return cache[type].GetMethod(field);
        }

        public static PropertyInfo GetProperty(Type type, string field)
        {
            if (cache == null)
                cache = new Dictionary<Type, CachedReflectionType>();

            if (!cache.ContainsKey(type))
                cache.Add(type, new CachedReflectionType(type));

            return cache[type].GetProperty(field);
        }
    }
}