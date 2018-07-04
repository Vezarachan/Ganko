using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Ganko
{
    partial class Ganko
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ganko));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.geckoWebBrowser2 = new Gecko.GeckoWebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.geckoWebBrowser3 = new Gecko.GeckoWebBrowser();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.geckoWebBrowser4 = new Gecko.GeckoWebBrowser();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.ChangeIco = new System.Windows.Forms.Button();
            this.AccountName = new MaterialSkin.Controls.MaterialLabel();
            this.posInfo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.companyInfo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ageInfo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Back = new System.Windows.Forms.ToolStripButton();
            this.Forward = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Star = new System.Windows.Forms.ToolStripButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Controls.Add(this.tabPage7);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.materialTabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 83);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(901, 439);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer3);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "iOS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.geckoWebBrowser1);
            this.splitContainer3.Size = new System.Drawing.Size(887, 403);
            this.splitContainer3.SplitterDistance = 247;
            this.splitContainer3.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 403);
            this.listBox1.TabIndex = 0;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_DrawItem);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geckoWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new System.Drawing.Size(636, 403);
            this.geckoWebBrowser1.TabIndex = 0;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer4);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Android";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.listBox2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.geckoWebBrowser2);
            this.splitContainer4.Size = new System.Drawing.Size(887, 403);
            this.splitContainer4.SplitterDistance = 247;
            this.splitContainer4.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(247, 403);
            this.listBox2.TabIndex = 0;
            this.listBox2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_DrawItem);
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // geckoWebBrowser2
            // 
            this.geckoWebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geckoWebBrowser2.Location = new System.Drawing.Point(0, 0);
            this.geckoWebBrowser2.Name = "geckoWebBrowser2";
            this.geckoWebBrowser2.Size = new System.Drawing.Size(636, 403);
            this.geckoWebBrowser2.TabIndex = 0;
            this.geckoWebBrowser2.UseHttpActivityObserver = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer5);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(893, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "前端";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.listBox3);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.geckoWebBrowser3);
            this.splitContainer5.Size = new System.Drawing.Size(893, 409);
            this.splitContainer5.SplitterDistance = 248;
            this.splitContainer5.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 12;
            this.listBox3.Location = new System.Drawing.Point(0, 0);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(248, 409);
            this.listBox3.TabIndex = 0;
            this.listBox3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_DrawItem);
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // geckoWebBrowser3
            // 
            this.geckoWebBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geckoWebBrowser3.Location = new System.Drawing.Point(0, 0);
            this.geckoWebBrowser3.Name = "geckoWebBrowser3";
            this.geckoWebBrowser3.Size = new System.Drawing.Size(641, 409);
            this.geckoWebBrowser3.TabIndex = 0;
            this.geckoWebBrowser3.UseHttpActivityObserver = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer6);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(893, 409);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "APP";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.listBox4);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.geckoWebBrowser4);
            this.splitContainer6.Size = new System.Drawing.Size(893, 409);
            this.splitContainer6.SplitterDistance = 248;
            this.splitContainer6.TabIndex = 1;
            // 
            // listBox4
            // 
            this.listBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 45;
            this.listBox4.Location = new System.Drawing.Point(0, 0);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(248, 409);
            this.listBox4.TabIndex = 0;
            this.listBox4.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_DrawItem);
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // geckoWebBrowser4
            // 
            this.geckoWebBrowser4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geckoWebBrowser4.Location = new System.Drawing.Point(0, 0);
            this.geckoWebBrowser4.Name = "geckoWebBrowser4";
            this.geckoWebBrowser4.Size = new System.Drawing.Size(641, 409);
            this.geckoWebBrowser4.TabIndex = 0;
            this.geckoWebBrowser4.UseHttpActivityObserver = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(893, 409);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Favorite";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage6.Controls.Add(this.materialLabel5);
            this.tabPage6.Controls.Add(this.ChangeIco);
            this.tabPage6.Controls.Add(this.AccountName);
            this.tabPage6.Controls.Add(this.posInfo);
            this.tabPage6.Controls.Add(this.companyInfo);
            this.tabPage6.Controls.Add(this.ageInfo);
            this.tabPage6.Controls.Add(this.materialLabel4);
            this.tabPage6.Controls.Add(this.materialLabel3);
            this.tabPage6.Controls.Add(this.materialLabel2);
            this.tabPage6.Controls.Add(this.materialLabel1);
            this.tabPage6.Controls.Add(this.userPicture);
            this.tabPage6.Location = new System.Drawing.Point(4, 26);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(893, 409);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "User";
            // 
            // ChangeIco
            // 
            this.ChangeIco.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ChangeIco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeIco.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChangeIco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChangeIco.Location = new System.Drawing.Point(156, 239);
            this.ChangeIco.Name = "ChangeIco";
            this.ChangeIco.Size = new System.Drawing.Size(113, 32);
            this.ChangeIco.TabIndex = 9;
            this.ChangeIco.Text = "Change Ico";
            this.ChangeIco.UseVisualStyleBackColor = false;
            this.ChangeIco.Click += new System.EventHandler(this.ChangeIco_Click);
            // 
            // AccountName
            // 
            this.AccountName.AutoSize = true;
            this.AccountName.Depth = 0;
            this.AccountName.Font = new System.Drawing.Font("Roboto", 11F);
            this.AccountName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AccountName.Location = new System.Drawing.Point(470, 92);
            this.AccountName.MouseState = MaterialSkin.MouseState.HOVER;
            this.AccountName.Name = "AccountName";
            this.AccountName.Size = new System.Drawing.Size(0, 18);
            this.AccountName.TabIndex = 8;
            // 
            // posInfo
            // 
            this.posInfo.Depth = 0;
            this.posInfo.Hint = "";
            this.posInfo.Location = new System.Drawing.Point(473, 237);
            this.posInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.posInfo.Name = "posInfo";
            this.posInfo.PasswordChar = '\0';
            this.posInfo.SelectedText = "";
            this.posInfo.SelectionLength = 0;
            this.posInfo.SelectionStart = 0;
            this.posInfo.Size = new System.Drawing.Size(199, 23);
            this.posInfo.TabIndex = 7;
            this.posInfo.UseSystemPasswordChar = false;
            // 
            // companyInfo
            // 
            this.companyInfo.Depth = 0;
            this.companyInfo.Hint = "";
            this.companyInfo.Location = new System.Drawing.Point(473, 183);
            this.companyInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.companyInfo.Name = "companyInfo";
            this.companyInfo.PasswordChar = '\0';
            this.companyInfo.SelectedText = "";
            this.companyInfo.SelectionLength = 0;
            this.companyInfo.SelectionStart = 0;
            this.companyInfo.Size = new System.Drawing.Size(199, 23);
            this.companyInfo.TabIndex = 6;
            this.companyInfo.UseSystemPasswordChar = false;
            // 
            // ageInfo
            // 
            this.ageInfo.Depth = 0;
            this.ageInfo.Hint = "";
            this.ageInfo.Location = new System.Drawing.Point(473, 133);
            this.ageInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.ageInfo.Name = "ageInfo";
            this.ageInfo.PasswordChar = '\0';
            this.ageInfo.SelectedText = "";
            this.ageInfo.SelectionLength = 0;
            this.ageInfo.SelectionStart = 0;
            this.ageInfo.Size = new System.Drawing.Size(199, 23);
            this.ageInfo.TabIndex = 5;
            this.ageInfo.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(360, 233);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(64, 18);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Position";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(360, 181);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(71, 18);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Company";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(360, 129);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(34, 18);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Age";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(360, 83);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 18);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Account";
            // 
            // userPicture
            // 
            this.userPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPicture.Location = new System.Drawing.Point(133, 83);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(150, 150);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label3);
            this.tabPage7.Controls.Add(this.label2);
            this.tabPage7.Controls.Add(this.label1);
            this.tabPage7.Controls.Add(this.button1);
            this.tabPage7.Location = new System.Drawing.Point(4, 26);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(893, 409);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Settings";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "This a Gank.io Client Demo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 44);
            this.label2.TabIndex = 10;
            this.label2.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "Themes";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(193, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.changeTheme_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Back,
            this.Forward,
            this.toolStripButton1,
            this.Star});
            this.toolStrip1.Location = new System.Drawing.Point(0, 525);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(900, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Back
            // 
            this.Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(23, 22);
            this.Back.ToolTipText = "Back";
            this.Back.Click += new System.EventHandler(this.backwardButton_Click);
            // 
            // Forward
            // 
            this.Forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Forward.Image = ((System.Drawing.Image)(resources.GetObject("Forward.Image")));
            this.Forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(23, 22);
            this.Forward.Text = "toolStripButton2";
            this.Forward.ToolTipText = "Forward";
            this.Forward.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Refresh";
            this.toolStripButton1.Click += new System.EventHandler(this.ReLoad);
            // 
            // Star
            // 
            this.Star.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Star.Image = ((System.Drawing.Image)(resources.GetObject("Star.Image")));
            this.Star.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Star.Name = "Star";
            this.Star.Size = new System.Drawing.Size(23, 22);
            this.Star.Text = "toolStripButton2";
            this.Star.ToolTipText = "Star";
            this.Star.Click += new System.EventHandler(this.Star_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 60);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(900, 23);
            this.materialTabSelector1.TabIndex = 19;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(8, 17);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(233, 35);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "User Information";
            // 
            // Ganko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Ganko";
            this.Text = "Ganko";
            this.Load += new System.EventHandler(this.Ganko_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private ListBox listBox1;
        private SplitContainer splitContainer4;
        private ListBox listBox2;
        private SplitContainer splitContainer5;
        private ListBox listBox3;
        private SplitContainer splitContainer6;
        private ListBox listBox4;
        private TabPage tabPage5;
        private Gecko.GeckoWebBrowser geckoWebBrowser1;
        private Gecko.GeckoWebBrowser geckoWebBrowser2;
        private Gecko.GeckoWebBrowser geckoWebBrowser3;
        private Gecko.GeckoWebBrowser geckoWebBrowser4;
        private ToolStrip toolStrip1;
        private ToolStripButton Back;
        private ToolStripButton Forward;
        private ToolStripButton toolStripButton1;
        private ToolStripButton Star;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private MaterialTabSelector materialTabSelector1;
        private PictureBox userPicture;
        private MaterialLabel materialLabel1;
        private MaterialLabel materialLabel2;
        private MaterialLabel materialLabel3;
        private MaterialLabel materialLabel4;
        private MaterialSingleLineTextField ageInfo;
        private MaterialSingleLineTextField posInfo;
        private MaterialSingleLineTextField companyInfo;
        private MaterialLabel AccountName;
        private Button ChangeIco;
        private MaterialLabel materialLabel5;
    }
}

