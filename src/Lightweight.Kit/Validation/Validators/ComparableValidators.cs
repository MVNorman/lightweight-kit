using System.Runtime.CompilerServices;

namespace Lightweight.Kit.Validation.Validators;

public static class ComparableValidators
{
    /// <summary>
    /// Throws an exception if the value is not in range
    /// </summary>
    /// <param name="value"></param>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <param name="paramName"></param>
    /// <typeparam name="T"></typeparam>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ThrowIfNotInRange<T>(
        this T value,
        T min,
        T max,
        [CallerArgumentExpression("value")] string paramName = "")
        where T : notnull, IComparable
    {
        if (Comparer<T>.Default.Compare(value, min) < 0 || Comparer<T>.Default.Compare(value, max) > 0)
        {
            throw new ArgumentOutOfRangeException(message: $"Value should be between {min} and {max}.", paramName: paramName);
        }
    }
}