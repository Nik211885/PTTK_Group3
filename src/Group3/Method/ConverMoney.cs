using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;

namespace Group3.Method
{
    public static  class ConverMoney
    {
        public static string convertMoney(ulong money)
        {
            var a = money.ToString();
            var bulding = new StringBuilder();
            int i = a.Length;
            int j = 0;
            if (i % 3 != 0)
            {
                j = i % 3;
                bulding.Append(a.Substring(0, j));
                bulding.Append(".");
            }
            while (j < i - 1)
            {
                bulding.Append(a.Substring(j, 3));
                bulding.Append(".");
                j = j + 3;
            }
            bulding.Remove(bulding.Length - 1, 1);
            bulding.Append("đ");
            return bulding.ToString();  
        }
    }
}
