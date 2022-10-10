using System.Runtime.ExceptionServices;
using Lightweight.Kit.RailwayOriented.Extensions;

namespace Lightweight.Kit.RailwayOriented.Monads;

public class Monad<T>
{
    public T Value { get; set; }
    public ExceptionDispatchInfo Exception { get; set; }
    public bool HasFailure => Exception is not null;
    public bool IsSucceeded => Exception is null;

    public Monad()
    {
    }
    
    public Monad(ExceptionDispatchInfo e)
    {
        Exception = e;
    }
    
    public static Monad<T> Create()
    {
        return new Monad<T>();
    }

    public static Monad<T> Create(Func<T> action)
    {
        Monad<T> monad = new();

        try
        {
            monad.Value = action();
        }
        catch (Exception e)
        {
            monad.Catch(e);
        }

        return monad;
    }
    
    public static Monad<TU> Create<TA, TU>(Func<TA, TU> action, TA value)
    {
        Monad<TU> monad = new();
    
        try
        {
            monad.Value = action(value);
        }
        catch (Exception e)
        {
            monad.Catch(e);
        }
    
        return monad;
    }

    public static Monad<T> Success(T value)
    {
        return new Monad<T>
        {
            Value = value
        };
    }
    
    public static Monad<T> Failure(Exception e)
    {
        return new Monad<T>
        {
            Exception = ExceptionDispatchInfo.Capture(e)
        };
    }
    
    public static Monad<T> Failure(ExceptionDispatchInfo dispatch)
    {
        return new Monad<T>
        {
            Exception = dispatch
        };
    }
}