using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group3.Method
{
    public static class SenCode
    {
        private static string a=null;
        public static async Task sendEmail(string name, string email)
        {
            Random rd = new Random();
            var t = rd.Next(100000, 999999).ToString();
            a = t;
            await Method.MailServer.SendEmail(name, email, t);
        }
        public static bool ConfirmCode(string code)
        {
            
            if(code == a) { return true; }
            return false;
        }
    }
}
