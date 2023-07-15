using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Group3.Method
{
    public static class ValidateValue
    {
        public static bool isEmail(string email)=> new Regex(@"^([\w\.\+-]+)@([\w\-]+)((\.(\w){2,3})+)$").IsMatch(email);
        public static bool isPassword(string password)=>new Regex(@"^[a-zA-Z0-9_@#$%^*()<>?/|}{~:.]+$").IsMatch(password) && password.Length >= 6;
        public static bool isName(string name)
        {
            if(name.Trim().Length == 0||name==null) return false;
            else 
            { 
                foreach (var i in name)
                {
                    if ((i < 'A' && i >= '!') || (i > 'Z' && i < 'a') || (i > 'z' && i <= '~'))
                        return false;
                }
            }
            return true;
        }
    }
}
