using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OtherFunction
{
    public static class HelpFunction
    {
        public static string CropWord(this string inputString, int maxChars)
        {
            if (maxChars <= 0)
                throw new ArgumentOutOfRangeException("maxChars");
            if (inputString == null || inputString.Length < maxChars)
                return inputString;
            var lastSpaceIndex = inputString.LastIndexOf(" ", maxChars);
            var substringLength = (lastSpaceIndex > 0) ? lastSpaceIndex : maxChars;
            var truncatedString = inputString.Substring(0, substringLength).Trim() + "...";

            return truncatedString;
        }
    }
}