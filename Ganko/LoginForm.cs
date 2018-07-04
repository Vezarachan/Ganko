using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ganko.ApiProcessor;
using Ganko.Commons.Security;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Ganko
{
    public partial class LoginForm : MaterialForm
    {
        //声明UI管理器，获取UI管理器实例
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        //声明安全模块，获取安全实例
        private readonly SecurityProcessor security = SecurityProcessor.Instance;

        //声明数据库模块，获取数据库实例
        private readonly MySQLDBHelper dbHelper = MySQLDBHelper.Instance;

        public LoginForm()
        {
            InitializeComponent();
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        //关闭窗体
        private void LoginCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //注册按钮，打开注册页面
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SignUpForm singForm = new SignUpForm();
            singForm.ShowDialog();
        }

        //登录按钮
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            var account = accountForm.Text;
            var password = passwordForm.Text;
            if (security.VerifyIsUserExist(account)) //dbHelper.GetUserByAccountHash(account).Account == null
            {
                MessageBox.Show("The account does't exist, please sign up first", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (security.VerifyPassword(password, dbHelper.GetUserByAccountHash(account).Password))
                {
                    Ganko ganko = new Ganko();
                    ganko.accountName = account;
                    this.Hide();
                    ganko.Show();
                    
                }
                else
                {
                    MessageBox.Show("Your password is wrong, please try again", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
