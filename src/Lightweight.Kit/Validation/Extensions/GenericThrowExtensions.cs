using System.Runtime.CompilerServices;

namespace Lightweight.Kit.Validation.Extensions
{
    public static class GenericThrowExtensions
    {
        public static void ThrowIfNull<T>(this T value, [CallerArgumentExpression("value")] string paramName = "")
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }
    }
}