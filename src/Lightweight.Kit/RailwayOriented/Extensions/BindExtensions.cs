namespace Lightweight.Kit.RailwayOriented.Extensions;

public static class BindExtensions
{
    public static Railway Bind(this Railway railway, Func<Railway> action)
    {
        return railway.IsSucceeded
            ? action()
            : railway;
    }

    public static Railway<TU> Bind<T, TU>(this Railway<T> railway, Func<T, Railway<TU>> action)
    {
        if (railway.IsSucceeded)
        {
            return action(railway.Value);
        }

        return new Railway<TU>(railway.Exception);
    }
}