using System;
using System.Collections.Generic;
using System.Linq;

namespace TestMyApp
{
    class Program
    {
        static void Main(string[] args) { }

    }

    public static class Extensions
    {
        public static IEnumerable<T> SkipFromEnd<T>(this IEnumerable<T> source, int amountToSkip)
        {
            if (source == null)
                throw new ArgumentNullException($"{nameof(source)} is null.");

            return source.Reverse().Skip(amountToSkip).Reverse();

        }


        public static bool IsPalindrom(this string sourceString)
        {
            if (string.IsNullOrWhiteSpace(sourceString))
            {
                throw new ArgumentException($"{ nameof(sourceString)} should not be null or empty. ");
            }
            int startIndex = 0;
            int endIndex = sourceString.Length - 1;
            bool contTest = false;

            while (startIndex < endIndex)
            {
                char startChar = Char.ToLower(sourceString[startIndex]);
                char endChar = Char.ToLower(sourceString[endIndex]);

                if (!Char.IsLetterOrDigit(startChar))
                {
                    startIndex++;
                    continue;
                }

                if (!Char.IsLetterOrDigit(endChar))
                {
                    endIndex--;
                    continue;
                }
                contTest = true;
                if (startChar != endChar)
                    return false;
                startIndex++;
                endIndex--;
            }

            if (!contTest)
                return false;
            return true;
        }
    }
}
