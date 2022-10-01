using System.Text.RegularExpressions;
using Lightweight.Kit.Validation.Extensions;

namespace Lightweight.Kit.Extensions
{
    public static class StringExtensions
    {
        public static string[] SplitCamelCase(this string source)
        {
            return Regex.Split(source, @"(?<!^)(?=[A-Z])");
        }

        public static string SplitCamelCaseToSpaceSeparated(this string source)
        {
            return string.Join(" ", source.SplitCamelCase());
        }

        public static string SplitCamelCaseToCharacterSeparated(this string source, string separator)
        {
            return string.Join(separator, source.SplitCamelCase());
        }

        public static string ToSnakeCase(this string value)
        {
            value.ThrowIfNull();
            
            return string
                .Concat(value.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString()))
                .ToLower();
        }

        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            return value.Length <= maxLength
                ? value
                : value.Substring(0, maxLength);
        }
        
        public static decimal? ToNullableDecimal(this string value)
        {
            return decimal.TryParse(value, out decimal i)
                ? i
                : null;
        }
        
        public static int? ToNullableInt(this string value)
        {
            return int.TryParse(value, out int i)
                ? i
                : null;
        }
        
        public static string ToSentenceCase(this string value)
        {
            value.ThrowIfNull();

            Regex regex = new Regex(@"(^[a-z])|\.\s+(.)", RegexOptions.ExplicitCapture);

            return regex.Replace(value.ToLower(), s => s.Value.ToUpper());
        }

        public static string ToPascaleCase(this string value)
        {
            value.ThrowIfNull();
            
            return CultureInfo.CurrentCulture.TextInfo
                .ToTitleCase(value.SplitCamelCaseToSpaceSeparated().Replace("-", " ").Replace("_", " "))
                .Replace(" ", string.Empty);
        }

        public static string ToCamelCase(this string value)
        {
            value.ThrowIfNull();

            if (value.Length < 2)
                return value.ToLower();

            string pascalCase = value.ToPascaleCase();

            return char.ToLowerInvariant(pascalCase[0]) + pascalCase.Substring(1);
        }

        public static string ToDashedCase(this string value)
        {
            value.ThrowIfNull();
            
            return value
                .ToPascaleCase()
                .SplitCamelCaseToCharacterSeparated("-")
                .ToLower();
        }

        public static string AsSafe(this string str)
        {
            return str ?? string.Empty;
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
    }
}
