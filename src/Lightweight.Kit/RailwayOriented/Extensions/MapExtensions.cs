namespace Lightweight.Kit.RailwayOriented.Extensions;

public static class MapExtensions
{
    public static Railway<T> Map<T>(this Railway<T> railway, Func<T, T> action)
    {
        try
        {
            T result = action(railway.Value);

            railway.Value = result;
        }
        catch (Exception exception)
        {
            railway.Exception = exception;

            throw;
        }

        return railway;
    }
}