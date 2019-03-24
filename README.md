# cached-reflection
Bite-sized reflection cacher for C# to make reflection speedy fast. I personally use it for my projects in Unity3D :)

### Usage

```
FieldInfo field = ReflectionCache.GetField(myType, fieldName);
MethodInfo method = ReflectionCache.GetMethod(myType, methodName);
PropertyInfo property = ReflectionCache.GetProperty(myType, propertyName);
```
