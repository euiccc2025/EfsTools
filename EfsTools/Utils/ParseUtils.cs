using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace EfsTools.Utils
{
    internal static class ParseUtils
    {
        public static byte[] ParseHexString(string hex)
        {
            hex = Regex.Replace(hex, @"\s+", "");
            if (hex.Length % 2 != 0)
            {
                throw new ArgumentException("Hex string must have an even number of characters.");
            }

            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        public static byte[] ParseDecString(string dec)
        {
            return dec.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                      .Select(byte.Parse)
                      .ToArray();
        }
    }
}