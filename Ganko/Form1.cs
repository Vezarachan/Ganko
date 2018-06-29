using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ganko.ApiProcessor;
using Ganko.Commons.DBHelper;
using Ganko.Commons.Models;
using Gecko;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Ganko
{
    public partial class Ganko : MaterialForm
    {
        //声明Api处理模块
        private APIProcessor apiProcessor = APIProcessor.GetInstance();
        //声明数据处理模块（MySQL）
        private MySQLDBHelper dbHelper = MySQLDBHelper.GetInstance();
        //声明数据处理模块（SQLite）
        private SQLiteDBHelper sqLiteDbHelper = SQLiteDBHelper.GetInstance();
        //声明UI管理器
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        //加载FireFox的xulrunner插件路径
        private readonly string xulrunnerpath = Application.StartupPath + "/xulrunner";
        public Ganko()
        {
            InitializeComponent();
            //初始化xulrunner
            Xpcom.Initialize(xulrunnerpath);
            //将Form加入UI管理器
            materialSkinManager.AddFormToManage(this);
            //设置初始化的主题
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //初始化主题配色
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        //更换主题使用的下标
        private int themeIndex;
        //更换颜色主题
        private void button1_Click(object sender, EventArgs e)
        {
            themeIndex++;
            if (themeIndex > 4)
            {
                themeIndex = 0;
            }

            switch (themeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    break;
                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                    break;
                case 3:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red400, Primary.Red800, Accent.Pink400, TextShade.WHITE);
                    break;
                case 4:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan200, Primary.Cyan600, Primary.Red500, Accent.Amber100, TextShade.BLACK);
                    break;
            }
        }

        //声明页码的值
        private int iOSindex = 1;
        private int androidindex = 1;
        private int frontendindex = 1;
        private int appindex = 1;
        //用于显示页面的中间值
        private List<iOS> iOSs;
        private List<Android> androids;
        private List<前端> frontends;
        private List<App> apps;

        //封装获取API的方法
        public async Task<List<T>> GetResult<T>(int page) where T : ResultModel
        {
            var content = await apiProcessor.GetResultContent<T>(8, page);
            return content;
        }

        //开启应用时，加载内容
        private async void Ganko_Load(object sender, EventArgs e)
        {
            var iOScontent = await GetResult<iOS>(iOSindex);
            iOSs = iOScontent;
            if (iOScontent != null)
            {
                iOScontent.ForEach(item => { listBox1.Items.Add(item.desc); });
            }

            var Androidcontent = await GetResult<Android>(androidindex);
            androids = Androidcontent;
            if (Androidcontent != null)
            {
                Androidcontent.ForEach(item => { listBox2.Items.Add(item.desc); });
            }

            var FrontEndcontent = await GetResult<前端>(frontendindex);
            frontends = FrontEndcontent;
            if (FrontEndcontent != null)
            {
                FrontEndcontent.ForEach(item => { listBox3.Items.Add(item.desc); });
            }

            var appcontent = await GetResult<App>(appindex);
            apps = appcontent;
            if (appcontent != null)
            {
                appcontent.ForEach(item => { listBox4.Items.Add(item.desc); });
            }
        }

        //重新加载渲染内容
        private async void ContentReLoad()
        {
            if (materialTabControl1.SelectedTab == tabPage1)
            {
                //清除列表内内容
                listBox1.Items.Clear();
                //获取内容
                var iOScontent = await GetResult<iOS>(iOSindex);
                iOSs = iOScontent;
                //在列表内重新加入新的内容
                iOScontent.ForEach(item => { listBox1.Items.Add(item.desc); });
            }
            else if (materialTabControl1.SelectedTab == tabPage2)
            {
                listBox2.Items.Clear();
                var androidcontent = await GetResult<Android>(androidindex);
                androids = androidcontent;
                androidcontent.ForEach(item => { listBox2.Items.Add(item.desc); });
            }
            else if (materialTabControl1.SelectedTab == tabPage3)
            {
                listBox3.Items.Clear();
                var frontendcontent = await GetResult<前端>(frontendindex);
                frontends = frontendcontent;
                frontendcontent.ForEach(item => { listBox3.Items.Add(item.desc); });
            }
            else if (materialTabControl1.SelectedTab == tabPage4)
            {
                listBox4.Items.Clear();
                var appcontent = await GetResult<App>(appindex);
                apps = appcontent;
                appcontent.ForEach(item => { listBox4.Items.Add(item.desc); });
            }
        }

        //显示选项对应的网页
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取当前列表
            ListBox listBox = (ListBox) sender;
            //获取当前列表内所有控件
            var desc = listBox.Items[listBox.SelectedIndex].ToString();
            if (materialTabControl1.SelectedTab == tabPage1)
            {
                iOSs.ForEach(item =>
                {
                    if (item.desc == desc)
                    {
                        geckoWebBrowser1.Navigate(item.url);
                    }
                });
            }
            else if (materialTabControl1.SelectedTab == tabPage2)
            {
                androids.ForEach(item =>
                {
                    if (item.desc == desc)
                    {
                        geckoWebBrowser2.Navigate(item.url);
                    }
                });
            }
            else if (materialTabControl1.SelectedTab == tabPage3)
            {
                frontends.ForEach(item =>
                {
                    if (item.desc == desc)
                    {
                        geckoWebBrowser3.Navigate(item.url);
                    }
                });
            }
            else if (materialTabControl1.SelectedTab == tabPage4)
            {
                apps.ForEach(item =>
                {
                    if (item.desc == desc)
                    {
                        geckoWebBrowser4.Navigate(item.url);
                    }
                });
            }
        }

        //对ListBox进行重绘，改善外观
        private void listBox_DrawItem(object sender, DrawItemEventArgs e)
        {
                var listBox = (ListBox) sender;
                e.DrawBackground();
                Font ft = new Font("微软雅黑", 8);
                listBox.ItemHeight = 50;
                e.Graphics.DrawString(listBox.Items[e.Index].ToString(), ft, Brushes.DarkSlateGray, e.Bounds);
                e.DrawFocusRectangle();
        }

        //列表前进一个页面
        private async void forwardButton_Click(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == tabPage1)
            {
                //获取下一页的内容
                var content1 = await apiProcessor.GetResultContent<iOS>(1, iOSindex + 1);
                //判定下一页的内容是否为空，如果不为空，则加载下一页
                if (content1 != null)
                {
                    iOSindex++;
                    Console.WriteLine(iOSindex);
                }
            }
            else if (materialTabControl1.SelectedTab == tabPage2)
            {
                var content2 = await apiProcessor.GetResultContent<Android>(1, androidindex + 1);
                if (content2 != null)
                {
                    androidindex++;
                }
            }
            else if (materialTabControl1.SelectedTab == tabPage3)
            {
                var conten3 = await apiProcessor.GetResultContent<前端>(1, frontendindex + 1);
                if (conten3 != null)
                {
                    frontendindex++;
                }
            }
            else if (materialTabControl1.SelectedTab == tabPage4)
            {
                var content4 = await apiProcessor.GetResultContent<App>(1, appindex + 1);
                if (content4 != null)
                {
                    appindex++;
                    Console.WriteLine(appindex);
                }
            }

            //更新完下标，重新加载内容
            ContentReLoad();
        }

        //列表后退一个页面
        private void backwardButton_Click(object sender, EventArgs e)
        {

            if (materialTabControl1.SelectedTab == tabPage1)
            {
                //判定页码是否为第一页，若不为第一页，则执行回退操作
                if (iOSindex > 1)
                {
                    iOSindex--;
                    Console.WriteLine(iOSindex);
                }
            }
            else if (materialTabControl1.SelectedTab == tabPage2)
            {
                if (androidindex > 1)
                {
                    androidindex--;
                }
            }
            else if (materialTabControl1.SelectedTab == tabPage3)
            {
                if (frontendindex > 1)
                {
                    frontendindex--;
                }
            }
            else if (materialTabControl1.SelectedTab == tabPage4)
            {
                if (appindex > 1)
                {
                    appindex--;
                    Console.WriteLine(appindex);
                }
            }

            //更新完下标，重新加载内容
            ContentReLoad();
        }

        //刷新页面
        public void ReLoad(object sender, EventArgs e)
        {
            //刷新列表
            ContentReLoad();
        }

        private void dbTest_Click(object sender, EventArgs e)
        {
            var conn = dbHelper.Conn;
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Successful");
                }
            }
            catch (SQLiteException exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void Star_Click(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == tabPage1)
            {
                
            }
        }
    }
}
