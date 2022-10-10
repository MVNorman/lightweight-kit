using System.Runtime.ExceptionServices;
using Lightweight.Kit.RailwayOriented.Monads;

namespace Lightweight.Kit.RailwayOriented.Extensions;

public static class ExceptionExtensions
{
    public static void Catch<T>(this Monad<T> monad, Exception e)
    {
        monad.Exception = ExceptionDispatchInfo.Capture(e);
    }
}