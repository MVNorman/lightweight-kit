using System.Runtime.CompilerServices;

namespace Lightweight.Kit.Validation.Validators;

public static class BooleanValidators
{
    /// <summary>
    /// Throws an exception if the boolean value is true.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramName"></param>
    /// <exception cref="ArgumentException"></exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ThrowIfTrue(this bool value, [CallerArgumentExpression("value")] string paramName = "")
    {
        if (value)
            throw new ArgumentException("Value should not be true.", paramName);
    }

    /// <summary>
    /// Throws an exception if the boolean value is false.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramName"></param>
    /// <exception cref="ArgumentException"></exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ThrowIfFalse(this bool value, [CallerArgumentExpression("value")] string paramName = "")
    {
        if (!value)
            throw new ArgumentException("Value should not be false.", paramName);
    }
}