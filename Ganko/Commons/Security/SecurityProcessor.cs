using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Ganko.ApiProcessor;
using Ganko.Commons.Models;

namespace Ganko.Commons.Security
{ 
    /// <summary>
    /// 安全处理模块，负责各类校验功能
    /// </summary>
    class SecurityProcessor : ISecurityHub, ICloneable
    {
        //声明数据库模块
        private readonly MySQLDBHelper dbHelper = MySQLDBHelper.Instance;

        //防止被实例化
        private SecurityProcessor() { }

        //返回实例
        public static SecurityProcessor Instance
        {
            get
            {
                SecurityProcessor sp = new SecurityProcessor();
                return (SecurityProcessor) sp.Clone();
            }
        }

        //ICloneable接口的实现
        public object Clone()
        {
            return new SecurityProcessor().MemberwiseClone();
        }

        /// <summary>
        /// 获取一个字符串的32位16进制字符串格式MD5码
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public string GetHashMD5(string pwd)
        {
            MD5 md5Hash = new MD5CryptoServiceProvider();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(pwd));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// 验证用户密码是否正确
        /// </summary>
        /// <param name="pwd"></param>
        /// <param name="verificationCode"></param>
        /// <returns></returns>
        public bool VerifyPassword(string pwd, string verificationCode)
        {
            string hashOfPwd = GetHashMD5(pwd);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfPwd, verificationCode))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 验证用户是否存在
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public bool VerifyIsUserExist(string account)
        {
            var user = dbHelper.GetUserByAccountHash(account);
            if (user.Account == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
