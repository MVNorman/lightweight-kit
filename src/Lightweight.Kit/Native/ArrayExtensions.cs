using System;

namespace Lightweight.Kit.Native
{
    public static class ArrayExtensions
    {
        public static bool IsNullOrEmpty(this Array array)
        {
            return array == null || array.Length == 0;
        }

        public static bool NotNullOrEmpty(this Array array)
        {
            return IsNullOrEmpty(array) == false;
        }

        public static T[] OrEmpty<T>(this T[] array)
        {
            return array ?? Array.Empty<T>();
        }
    }
}