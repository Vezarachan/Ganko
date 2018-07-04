using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganko.Commons.Security
{
    interface ISecurityHub
    {
        string GetHashMD5(string pwd);

        bool VerifyPassword(string pwd, string verificationCode);
    }
}
