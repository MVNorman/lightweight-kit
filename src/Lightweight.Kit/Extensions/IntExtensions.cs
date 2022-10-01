// ReSharper disable MemberCanBePrivate.Global

namespace Lightweight.Kit.Extensions
{
    public static class IntExtensions
    {
        public static bool BetweenInclusive(int value, int leftBoundary, int rightBoundary)
        {
            return value >= leftBoundary && value <= rightBoundary;
        }

        public static bool BetweenExclusive(int value, int leftBoundary, int rightBoundary)
        {
            return BetweenInclusive(value, leftBoundary + 1, rightBoundary - 1);
        }

        public static bool BetweenLeftInclusive(int value, int leftBoundary, int rightBoundary)
        {
            return BetweenInclusive(value, leftBoundary, rightBoundary - 1);
        }

        public static bool BetweenRightInclusive(int value, int leftBoundary, int rightBoundary)
        {
            return BetweenInclusive(value, leftBoundary + 1, rightBoundary);
        }
    }
}