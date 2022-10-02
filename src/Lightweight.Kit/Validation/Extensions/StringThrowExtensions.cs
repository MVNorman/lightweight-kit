using System.Runtime.CompilerServices;

namespace Lightweight.Kit.Validation.Extensions;

public static class StringThrowExtensions
{
    /// <summary>
    /// Throws an exception if the value is empty.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramName"></param>
    /// <exception cref="ArgumentException"></exception>
    public static void ThrowIfEmpty(this string value, [CallerArgumentExpression("value")] string paramName = "")
    {
        if (value.Length == default)
        {
            throw new ArgumentException(message: "String should not be empty.", paramName: paramName);
        }
    }
}