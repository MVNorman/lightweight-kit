﻿using System.Runtime.CompilerServices;

namespace Lightweight.Kit.Validation.Extensions
{
    public static class GenericThrowExtensions
    {
        /// <summary>
        /// Throws an exception if the value is null.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="paramName"></param>
        /// <typeparam name="T"></typeparam>
        /// <exception cref="ArgumentNullException"></exception>
        public static void ThrowIfNull<T>(this T value, [CallerArgumentExpression("value")] string paramName = "")
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }
    }
}