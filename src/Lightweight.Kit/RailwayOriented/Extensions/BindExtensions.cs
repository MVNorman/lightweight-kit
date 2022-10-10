using Lightweight.Kit.RailwayOriented.Monads;

namespace Lightweight.Kit.RailwayOriented.Extensions;

public static class BindExtensions
{
    public static Monad Bind(this Monad monad, Func<Monad> action)
    {
        return monad.IsSucceeded
            ? action()
            : monad;
    }

    public static Monad<TU> Bind<T, TU>(this Monad<T> monad, Func<T, Monad<TU>> action)
    {
        if (monad.IsSucceeded)
        {
            return action(monad.Value);
        }

        return new Monad<TU>(monad.Exception);
    }
}