using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganko.Commons.Models
{
    class User
    {
        private string _account;
        private string _password;

        public string Account
        {
            get { return _account; }
            set { _account = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public override string ToString()
        {
            return $"account: {_account}, password: {_password}";
        }
    }

    class UserDetails
    {
        private string _account;
        private int _age;
        private string _company;
        private string _position;

        public string Account
        {
            get { return _account; }
            set { _account = value; }
        }

        public int Age
        {
            get { return _age; }
            set {
                if (value <= 100 && value >= 0)
                {
                    _age = value;
                }
            }
        }

        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public override string ToString()
        {
            return $"account : {_account}, age : {_age}, company : {_company}, position : {_position}";
        }
    }
}
