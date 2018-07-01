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
            set
            {
                if (value != "")
                {
                    _account = value;
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (value != "")
                {
                    _password = value;
                }
            }
        }

        public override string ToString()
        {
            return $"account: {_account}, password: {_password}";
        }
    }
}
