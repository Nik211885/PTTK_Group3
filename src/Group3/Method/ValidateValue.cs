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
        public static bool isEmail(string email) => new Regex(@"^([\w\.\+-]+)@([\w\-]+)((\.(\w){2,3})+)$").IsMatch(email);
        public static bool isPassword(string password) => new Regex(@"^[a-zA-Z0-9_@#$%^*()<>?/|}{~:.]+$").IsMatch(password) && password.Length >= 6;
        public static bool isName(string name)
        {
            if (name.Trim().Length == 0 || name == null) return false;
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
        public static bool isPhone(string phone)=>new Regex("^[0-9]+$").IsMatch(phone);
        public static bool isLeapYear(int year) => (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0));
        public static bool isYear(string day,string month,string year)
        {
            var dateNow = DateTime.UtcNow;
            
            try
            {
                int d = int.Parse(day);
                int y = int.Parse(year);
                int m = int.Parse(month);
                if (d < 0 || y < 0 || d > 31 || y > dateNow.Year || (y == dateNow.Year && ((m > dateNow.Month) || (m == dateNow.Month && d > dateNow.Day)))) { return false; }
                else
                {
                    if ((m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12) && d > 31) { return false; }
                    else
                    {
                        if ((m == 4 || m == 6 || m == 9 || m == 11) && d > 30) { return false; }
                        else
                        {
                            if (isLeapYear(y) && m == 2 && d > 29) { return false; }
                            if(!isLeapYear(y)&&m ==2 && d > 28) { return false; }

                        }
                    }
                    return true;
                }
            }
            catch { return false; }
        }
    }
}
