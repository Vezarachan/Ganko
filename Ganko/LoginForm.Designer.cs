using System.Drawing;

namespace Ganko
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.accountForm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordForm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.LoginCancel = new System.Windows.Forms.Button();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 126);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 18);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Account";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 176);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(74, 18);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Password";
            // 
            // accountForm
            // 
            this.accountForm.Depth = 0;
            this.accountForm.Hint = "Your Account@_@";
            this.accountForm.Location = new System.Drawing.Point(112, 121);
            this.accountForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.accountForm.Name = "accountForm";
            this.accountForm.PasswordChar = '\0';
            this.accountForm.SelectedText = "";
            this.accountForm.SelectionLength = 0;
            this.accountForm.SelectionStart = 0;
            this.accountForm.Size = new System.Drawing.Size(167, 23);
            this.accountForm.TabIndex = 2;
            this.accountForm.UseSystemPasswordChar = false;
            // 
            // passwordForm
            // 
            this.passwordForm.Depth = 0;
            this.passwordForm.Hint = "Your Password( ://";
            this.passwordForm.Location = new System.Drawing.Point(112, 171);
            this.passwordForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordForm.Name = "passwordForm";
            this.passwordForm.PasswordChar = '·';
            this.passwordForm.SelectedText = "";
            this.passwordForm.SelectionLength = 0;
            this.passwordForm.SelectionStart = 0;
            this.passwordForm.Size = new System.Drawing.Size(167, 23);
            this.passwordForm.TabIndex = 3;
            this.passwordForm.UseSystemPasswordChar = false;
            // 
            // SignInBtn
            // 
            this.SignInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(216)))), ((int)(((byte)(182)))));
            this.SignInBtn.FlatAppearance.BorderSize = 0;
            this.SignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInBtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SignInBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SignInBtn.Location = new System.Drawing.Point(36, 240);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(226, 32);
            this.SignInBtn.TabIndex = 4;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = false;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // LoginCancel
            // 
            this.LoginCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.LoginCancel.FlatAppearance.BorderSize = 0;
            this.LoginCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginCancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginCancel.Location = new System.Drawing.Point(36, 278);
            this.LoginCancel.Name = "LoginCancel";
            this.LoginCancel.Size = new System.Drawing.Size(226, 32);
            this.LoginCancel.TabIndex = 5;
            this.LoginCancel.Text = "Cancel";
            this.LoginCancel.UseVisualStyleBackColor = false;
            this.LoginCancel.Click += new System.EventHandler(this.LoginCancel_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.materialFlatButton1.Location = new System.Drawing.Point(198, 315);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(64, 36);
            this.materialFlatButton1.TabIndex = 6;
            this.materialFlatButton1.Text = "Sign Up";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 355);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.LoginCancel);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.passwordForm);
            this.Controls.Add(this.accountForm);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField accountForm;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordForm;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Button LoginCancel;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}