﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Ganko
{
    public partial class SignUpForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public SignUpForm()
        {
            InitializeComponent();
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void SignUpCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
