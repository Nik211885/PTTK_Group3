using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group3.Method
{
    public static class MulitiLabel
    {
        public static string Multi(string name,int lenght)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while(i<name.Length-lenght)
            {
                for (int j = (i + lenght); j > i; j--)
                {
                    if (name[j]==' ')
                    {
                        sb.Append(name.Substring(i, j - i));
                        sb.Append("\n");
                        i = j+1;
                        break;

                    }
                }
            }
            sb.Append(name.Substring(i, name.Length - i));
            return sb.ToString();
        }
    }
}
