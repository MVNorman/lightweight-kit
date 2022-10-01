namespace Lightweight.Kit.Extensions
{
    public static class BooleanExtensions
    {
        public static string ToYesNo(this bool value)
        {
            return value ? "Yes" : "No";
        }

        public static int ToBit(this bool value)
        {
            return value ? 1 : 0;
        }
    }
}