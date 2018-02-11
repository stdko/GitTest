using System;
using System.Collections.Generic;
using System.Linq;

namespace TestMyApp
{
    class Program
    {
        static void Main(string[] args)
        {
	    var array = new[] {1,2,3,4,5,6,7,8,9,10,11,12,13};
            array.SkipFromEnd(3);
            var str = "ttttr  ";
            str = str.TrriimmmEnd();
            "ttttr  ".TrriimmmEnd();
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
                Console.WriteLine($"{nameof(item)}: {item}");
            }
            return tmp;

        }

        public static string TrriimmmEnd(this string str)
        {
            var trimmedChars = new Char[] {' ',','};
            return str.TrimEnd(trimmedChars);
        }

        public static bool IsPalindrom(this string srcStr)
        {
            if (string.IsNullOrWhiteSpace(srcStr))
            {
                throw new ArgumentException($"{ nameof(srcStr)} should not be null or empty. ");
            }
            int startIndex = 0;
            int endIndex = srcStr.Length - 1;
            bool contTest = false;

            while (startIndex < endIndex)
            {
                char startChar = Char.ToLower(srcStr[startIndex]);
                char endChar = Char.ToLower(srcStr[endIndex]);

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

        public static void Prrinttt(this string prprpr)
        {
            Console.WriteLine(prprpr);
        }
    }
}
