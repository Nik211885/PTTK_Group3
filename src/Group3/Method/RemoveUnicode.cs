using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Group3.Method
{
    public static class RemoveUnicode
    {
        static Regex ConvertToUnsign_rg = null;
        public static string unicode(string text)
        {
            if (ReferenceEquals(ConvertToUnsign_rg, null))
            {
                ConvertToUnsign_rg = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            }
            var temp = text.Normalize(NormalizationForm.FormD);
            return ConvertToUnsign_rg.Replace(temp, string.Empty).Replace("đ", "d").Replace("Đ", "D").ToLower();
        }
    }
}
