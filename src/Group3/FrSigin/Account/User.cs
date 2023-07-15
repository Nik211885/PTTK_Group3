using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3.FrSigin.Account
{
    public class User
    {
        private string _name;
        private string _password;
        private string _male;
        private DateTime _birthday;
        private string _address;
        private string _phone;
        private string _email;
        private string _img;
        public string Name { get { return _name; } set { _name = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string Male { get { return _male; } set { _male = value; } }
        public DateTime birthDay { get { return _birthday; } set { _birthday = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Img { get { return _img; } set { _img = value; } }

    }
}
