using System.Reflection;

namespace Lightweight.Kit.Extensions;

public static class AttributeExtensions
{
    public static T GetCustomAttribute<T>(this object value) where T : Attribute
    {
        return CustomAttributeExtensions.GetCustomAttribute<T>(value.GetType());
    }
}