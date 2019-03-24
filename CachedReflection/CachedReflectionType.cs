using System.Reflection;
using System.Collections.Generic;
using System;

namespace Ardenfall.Reflection
{
    public class CachedReflectionType
    {
        private Type type;
        private Dictionary<string, FieldInfo> fields;
        private Dictionary<string, MethodInfo> methods;
        private Dictionary<string, PropertyInfo> properties;

        private FieldInfo[] allFields;
        private MethodInfo[] allMethods;
        private PropertyInfo[] allProperties;

        public CachedReflectionType(Type type)
        {
            this.type = type;
            fields = new Dictionary<string, FieldInfo>();
            methods = new Dictionary<string, MethodInfo>();
            properties = new Dictionary<string, PropertyInfo>();

            allFields = null;
        }

        public FieldInfo[] GetFields()
        {
            if (allFields == null)
                allFields = type.GetFields();
            return allFields;
        }

        public MethodInfo[] GetMethods()
        {
            if (allMethods == null)
                allMethods = type.GetMethods();
            return allMethods;
        }

        public PropertyInfo[] GetProperties()
        {
            if (allProperties == null)
                allProperties = type.GetProperties();
            return allProperties;
        }

        public FieldInfo GetField(string field)
        {
            if (!fields.ContainsKey(field))
                fields.Add(field, type.GetField(field));

            return fields[field];
        }

        public MethodInfo GetMethod(string method)
        {
            if (!methods.ContainsKey(method))
                methods.Add(method, type.GetMethod(method));

            return methods[method];
        }

        public PropertyInfo GetProperty(string property)
        {
            if (!properties.ContainsKey(property))
                properties.Add(property, type.GetProperty(property));

            return properties[property];

        }
    }
}