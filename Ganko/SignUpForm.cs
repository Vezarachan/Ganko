using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ganko.ApiProcessor;
using Ganko.Commons.Models;
using Ganko.Commons.Security;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Ganko
{
    /// <summary>
    /// 注册窗体类
    /// </summary>
    public partial class SignUpForm : MaterialForm
    {
        //UI管理器声明
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        //声明数据处理模块（MySQL）
        private readonly MySQLDBHelper dbHelper = MySQLDBHelper.Instance;

        //声明安全模块，获取实例
        private readonly SecurityProcessor security = SecurityProcessor.Instance;

        public SignUpForm()
        {
            InitializeComponent();
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void SignUpCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            int usrAge;
            var account = accountForm.Text;
            var password = pwdForm.Text;
            var age = ageForm.Text;
            var company = companyForm.Text;
            var position = posForm.Text;
            //用户登录表
            User user = new User();
            user.Account = account;
            user.Password = security.GetHashMD5(password);
            //用户详细信息表
            UserDetails userDetails = new UserDetails();
            userDetails.Account = account;
            if (int.TryParse(age, out usrAge))
            {
                userDetails.Age = usrAge;
            }
            userDetails.Company = company;
            userDetails.Position = position;
            //检查是否已经被注册
            if (security.VerifyIsUserExist(account)) //dbHelper.GetUserByAccountHash(account).Account == null
            {
                //MessageBox.Show(user.ToString());
                //添加用户登录信息
                dbHelper.AddUserHash(user);
                //添加用户详细信息
                dbHelper.AddUserDetail(userDetails);
                //提示注册注册成功
                MessageBox.Show("Sign up seccessfually! >_<", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //关闭窗体
                Close();
            }
            else
            {
                //已经有相同用户名注册用户，提示已注册
                MessageBox.Show("The account has existed", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
