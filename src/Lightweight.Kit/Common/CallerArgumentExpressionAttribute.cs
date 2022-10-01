#if !NET5_0 && !NET6_0

// ReSharper disable once CheckNamespace

namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
internal sealed class CallerArgumentExpressionAttribute : Attribute
{
    // ReSharper disable once MemberCanBePrivate.Global
    // ReSharper disable once UnusedAutoPropertyAccessor.Global
    public string ParameterName { get; }

    public CallerArgumentExpressionAttribute(string parameterName) => ParameterName = parameterName;
}
#endif