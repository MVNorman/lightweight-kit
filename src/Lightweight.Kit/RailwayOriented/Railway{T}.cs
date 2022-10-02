namespace Lightweight.Kit.RailwayOriented;

public class Railway<T>
{
    public T Value { get; set; }
    public Exception Exception { get; set; }
    public bool HasFailure => Exception is not null;
    public bool IsSucceeded => Exception is null;

    public Railway()
    {
    }
    
    public Railway(Exception exception)
    {
        Exception = exception;
    }
    
    public static Railway<T> Create()
    {
        return new Railway<T>();
    }
    
    public static Railway<T> Create(Func<T> action)
    {
        Railway<T> railway = new();

        try
        {
            railway.Value = action();
        }
        catch (Exception e)
        {
            railway.Exception = e;
        }

        return railway;
    }

    public static Railway<T> Success(T value)
    {
        return new Railway<T>
        {
            Value = value
        };
    }
}