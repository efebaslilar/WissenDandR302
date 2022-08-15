using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WissenDandR302EntityLayer.Helpers
{
    public static class Helper
    {
        public static string StringCharacterConverter(string txt)
        {
            string resultString = txt
            .Replace("'", "")
            .Replace(" ", "-")
            .Replace("<", "")
            .Replace(">", "")
            .Replace("&", "")
            .Replace("[", "")
            .Replace("!", "")
            .Replace("]", "")
            .Replace("ı", "i")
            .Replace("ö", "o")
            .Replace("ü", "u")
            .Replace("ş", "s")
            .Replace("ç", "c")
            .Replace("ğ", "g")
            .Replace("İ", "I")
            .Replace("Ö", "O")
            .Replace("Ü", "U")
            .Replace("Ş", "S")
            .Replace("Ç", "C")
            .Replace("Ğ", "G")
            .Replace("|", "")
            .Replace(".", "-")
            .Replace("?", "-")
            .Replace(";", "-");

            return resultString.ToLower();

        }
    }
}
