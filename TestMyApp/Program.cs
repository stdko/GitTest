using System;
using System.Collections.Generic;
using System.Linq;

namespace TestMyApp
{
    class Program
    {
        static void Main(string[] args) {
            var array = new[] {1,2,3,4,5,6,7,8,9,10};
            array.SkipFromEnd(3);

        }

    }

    public static class Extensions
    {
        public static IEnumerable<T> SkipFromEnd<T>(this IEnumerable<T> source, int amountToSkip)
        {
            if (source == null)
                throw new ArgumentNullException($"{nameof(source)} is null.");

            var tmp = source.Reverse().Skip(amountToSkip).Reverse();
            foreach (var item in tmp)
            {
                Console.WriteLine(item);
            }
            return tmp;

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
