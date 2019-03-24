# cached-reflection
Bite-sized reflection cacher for C# to make reflection speedy fast by caching fields, methods, and properties.
I personally use it for my projects in Unity3D :)

### Usage

```C#
FieldInfo field = ReflectionCache.GetField(myType, fieldName);
MethodInfo method = ReflectionCache.GetMethod(myType, methodName);
PropertyInfo property = ReflectionCache.GetProperty(myType, propertyName);
```
