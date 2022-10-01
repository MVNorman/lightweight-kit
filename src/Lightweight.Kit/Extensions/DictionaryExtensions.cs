﻿namespace Lightweight.Kit.Extensions
{
    public static class DictionaryExtensions
    {
        public static bool IsNullOrEmpty<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
        {
            return dictionary == null || dictionary.Any() == false;
        }
    }
}
