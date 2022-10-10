// ReSharper disable MemberCanBePrivate.Global

using Lightweight.Kit.Validation.Validators;

namespace Lightweight.Kit.RailwayOriented.DealingWithNoValue;

public struct Maybe<T>
{
    public static Maybe<T> None => new();

    public T Value { get; }

    public bool HasValue { get; }

    public Maybe(T value)
    {
        value.ThrowIfNull();
        
        Value = value;

        HasValue = true;
    }

    public static implicit operator T(Maybe<T> maybe)
    {
        return maybe.Value;
    }

    public static implicit operator Maybe<T>(T value)
    {
        return value is null
            ? None
            : new Maybe<T>(value);
    }
}