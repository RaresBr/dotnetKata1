using System;
using System.Linq;
using EnsureThat;

namespace Common
{
    public static class StringService
    {
        public static bool IsPalindome(this string input)
        {
            Ensure.That(input, "Not null").IsNotNullOrEmpty();
            return input.Reverse().SequenceEqual(input);
        }

        public static string Concatenate(params string[] values) => String.Join("", values);
    }
}
