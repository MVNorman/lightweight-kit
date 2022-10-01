using System.ComponentModel;
using System.Reflection;

namespace Lightweight.Kit.Extensions
{
    public static class EnumExtensions
    {
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
        
        public static string GetDescription<T>(this T enumValue) where T : Enum
        {
            string description = enumValue.ToString();
            
            FieldInfo fieldInfo = enumValue
                .GetType()
                .GetField(description);

            if (fieldInfo is null)
                return description;

            DescriptionAttribute[] customAttributes = fieldInfo
                .GetCustomAttributes<DescriptionAttribute>(true)
                .ToArray();
            
            if (customAttributes.Any())
                description = customAttributes[default].Description;

            return description;
        }
    }
}
