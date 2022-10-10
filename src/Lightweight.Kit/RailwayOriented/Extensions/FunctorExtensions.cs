using Lightweight.Kit.RailwayOriented.Monads;

namespace Lightweight.Kit.RailwayOriented.Extensions;

public static class FunctorExtensions
{
    public static Monad<TU> Map<T, TU>(this Monad<T> monad, Func<T, TU> action)
    {
        if (monad.HasFailure)
        {
            return new Monad<TU>(monad.Exception);
        }

        try
        {
            TU result = action(monad.Value);

            return Monad<TU>.Success(result);
        }
        catch (Exception e)
        {
            return Monad<TU>.Failure(e);
        }
    }
    
    public static Monad<TU> Map<T, TU>(this Func<T> action, Func<T, TU> executor)
    {
        try
        {
            Monad<T> monad = Monad<T>.Create(action);

            if (monad.HasFailure)
            {
                return Monad<TU>.Failure(monad.Exception);
            }

            return Monad<TU>.Create(executor, monad.Value);
        }
        catch (Exception e)
        {
            return Monad<TU>.Failure(e);
        }
    }
}