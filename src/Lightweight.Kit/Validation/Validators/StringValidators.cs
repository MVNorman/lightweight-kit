using System.Runtime.CompilerServices;

namespace Lightweight.Kit.Validation.Validators;

public static class StringValidators
{
    /// <summary>
    /// Throws an exception if the value is empty.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramName"></param>
    /// <exception cref="ArgumentException"></exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ThrowIfEmpty(this string value, [CallerArgumentExpression("value")] string paramName = "")
    {
        if (value.Length == default)
            throw new ArgumentException(message: "String should not be empty.", paramName: paramName);
    }
    
    /// <summary>
    /// Throws an exception if the value is null or empty.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramName"></param>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="ArgumentNullException"></exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ThrowIfNullOrEmpty(this string value, [CallerArgumentExpression("value")] string paramName = "")
    {
        if (value == null)
            throw new ArgumentNullException(paramName);
        
        if (value.Length == default)
            throw new ArgumentException(message: "String should not be empty.", paramName: paramName);
    }
}