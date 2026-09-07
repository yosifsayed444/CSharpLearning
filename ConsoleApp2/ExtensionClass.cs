using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp2
{
    internal static class ExtensionClass
    {
        //old way  --> ExtensionClass.IsNumberBetween(persentage, 0, 100))

        public static bool IsNumberBetween(int val, int min, int max)
        {
            return val >= min && val <= max;
        }
        // new way --> persentage.IsNumberBetweenUsingExtensionMethod(0,100))
        // must using static class & static function 
        public static bool IsNumberBetweenUsingExtensionMethod(this int val, int min, int max)
        {
            return val >= min && val <= max;
        }
    }

    internal static class ExtensionStringClass
    {
        // Remove all spaces
        public static string RemoveWhiteSpaces(this string val)
        {
            return val.Replace(" ", "");
        }

        // Reverse string
        public static string Reverse(this string val)
        {
            var charArray = val.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Capitalize first letter
        public static string Capitalize(this string val)
        {
            if (string.IsNullOrWhiteSpace(val))
                return val;

            return char.ToUpper(val[0]) + val.Substring(1);
        }

        // Check if string is palindrome
        public static bool IsPalindrome(this string val)
        {
            if (string.IsNullOrWhiteSpace(val))
                return false;

            string cleaned = val.Replace(" ", "").ToLower();

            return cleaned == cleaned.Reverse();
        }

        // Count words
        public static int WordCount(this string val)
        {
            if (string.IsNullOrWhiteSpace(val))
                return 0;

            return val.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }

        // Check if string contains only digits
        public static bool IsNumeric(this string val)
        {
            return val.All(char.IsDigit);
        }

        // Convert to Title Case
        public static string ToTitleCase(this string val)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(val.ToLower());
        }

        // Repeat string
        public static string Repeat(this string val, int times)
        {
            if (times <= 0)
                return string.Empty;

            return string.Concat(Enumerable.Repeat(val, times));
        }

        // Remove all digits
        public static string RemoveDigits(this string val)
        {
            return new string(val.Where(c => !char.IsDigit(c)).ToArray());
        }

        // Keep only digits
        public static string OnlyDigits(this string val)
        {
            return new string(val.Where(char.IsDigit).ToArray());
        }

        // Check if string is null or empty
        public static bool IsNullOrEmpty(this string val)
        {
            return string.IsNullOrEmpty(val);
        }

        // Check if string is null or whitespace
        public static bool IsNullOrWhiteSpaceEx(this string val)
        {
            return string.IsNullOrWhiteSpace(val);
        }

        // Count occurrences of a character
        public static int CountChar(this string val, char c)
        {
            return val.Count(x => x == c);
        }

        // Get initials
        public static string GetInitials(this string val)
        {
            if (string.IsNullOrWhiteSpace(val))
                return "";

            return string.Concat(
                val.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                   .Select(word => char.ToUpper(word[0]))
            );
        }

        // Mask string except last 4 chars
        public static string Mask(this string val)
        {
            if (string.IsNullOrEmpty(val) || val.Length <= 4)
                return val;

            return new string('*', val.Length - 4) + val[^4..];
        }

        // Check if contains letters only
        public static bool IsLettersOnly(this string val)
        {
            return val.All(char.IsLetter);
        }

        // Truncate string
        public static string Truncate(this string val, int length)
        {
            if (string.IsNullOrEmpty(val) || val.Length <= length)
                return val;

            return val.Substring(0, length);
        }

        // Remove special characters
        public static string RemoveSpecialCharacters(this string val)
        {
            return new string(val.Where(char.IsLetterOrDigit).ToArray());
        }

        // Count vowels
        public static int CountVowels(this string val)
        {
            string vowels = "aeiouAEIOU";

            return val.Count(c => vowels.Contains(c));
        }

        // Count consonants
        public static int CountConsonants(this string val)
        {
            string vowels = "aeiouAEIOU";

            return val.Count(c => char.IsLetter(c) && !vowels.Contains(c));
        }


        static int factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Negative numbers are not allowed.");
            if (n == 0 || n == 1)
                return 1;
            return n * factorial(n - 1);
        }

        static int factorialIterative(int n)
        {
            if (n < 0)
                throw new ArgumentException("Negative numbers are not allowed.");
            int result = 1;
            for (int i = n; i > 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
