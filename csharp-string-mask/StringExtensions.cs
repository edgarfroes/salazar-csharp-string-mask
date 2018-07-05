using System.Linq;

namespace csharp_string_mask
{
    public static class StringExtensions
    {
        public static string ToMask(this string value, params string[] masks)
        {
            var maskedOutput = "";

            var maskedCounter = 0;

            var mask = masks.ToList().FirstOrDefault(x =>
                 (x.Split("#").Count() - 1) == value.Length)
                 ?? masks[0];

            for (int i = 0; i < mask.Length; i++)
            {
                if (maskedCounter >= value.Length)
                {
                    return maskedOutput;
                }

                var maskChar = mask.Substring(i, 1);

                if (maskChar == "#")
                {
                    maskedOutput += value.Substring(maskedCounter, 1);
                    maskedCounter++;
                }
                else
                {
                    maskedOutput += maskChar;
                }
            }

            return maskedOutput;
        }
    }
}