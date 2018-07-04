namespace Ganko
{
    partial class SignUpForm
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
            this.pwdForm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.accountForm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SignUpCancelBtn = new System.Windows.Forms.Button();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.ageForm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.companyForm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.posForm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // pwdForm
            // 
            this.pwdForm.Depth = 0;
            this.pwdForm.Hint = "Your Password( :|";
            this.pwdForm.Location = new System.Drawing.Point(111, 118);
            this.pwdForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.pwdForm.Name = "pwdForm";
            this.pwdForm.PasswordChar = '·';
            this.pwdForm.SelectedText = "";
            this.pwdForm.SelectionLength = 0;
            this.pwdForm.SelectionStart = 0;
            this.pwdForm.Size = new System.Drawing.Size(167, 23);
            this.pwdForm.TabIndex = 7;
            this.pwdForm.UseSystemPasswordChar = false;
            // 
            // accountForm
            // 
            this.accountForm.Depth = 0;
            this.accountForm.Hint = "Your Account@>@";
            this.accountForm.Location = new System.Drawing.Point(111, 79);
            this.accountForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.accountForm.Name = "accountForm";
            this.accountForm.PasswordChar = '\0';
            this.accountForm.SelectedText = "";
            this.accountForm.SelectionLength = 0;
            this.accountForm.SelectionStart = 0;
            this.accountForm.Size = new System.Drawing.Size(167, 23);
            this.accountForm.TabIndex = 6;
            this.accountForm.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 123);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(74, 18);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Password";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 84);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 18);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Account";
            // 
            // SignUpCancelBtn
            // 
            this.SignUpCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.SignUpCancelBtn.FlatAppearance.BorderSize = 0;
            this.SignUpCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpCancelBtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SignUpCancelBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SignUpCancelBtn.Location = new System.Drawing.Point(36, 311);
            this.SignUpCancelBtn.Name = "SignUpCancelBtn";
            this.SignUpCancelBtn.Size = new System.Drawing.Size(226, 32);
            this.SignUpCancelBtn.TabIndex = 9;
            this.SignUpCancelBtn.Text = "Cancel";
            this.SignUpCancelBtn.UseVisualStyleBackColor = false;
            this.SignUpCancelBtn.Click += new System.EventHandler(this.SignUpCancelBtn_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(216)))), ((int)(((byte)(182)))));
            this.SignUpBtn.FlatAppearance.BorderSize = 0;
            this.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpBtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SignUpBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SignUpBtn.Location = new System.Drawing.Point(36, 273);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(226, 32);
            this.SignUpBtn.TabIndex = 8;
            this.SignUpBtn.Text = "OK";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // ageForm
            // 
            this.ageForm.Depth = 0;
            this.ageForm.Hint = "Your Age _>_";
            this.ageForm.Location = new System.Drawing.Point(111, 158);
            this.ageForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.ageForm.Name = "ageForm";
            this.ageForm.PasswordChar = '\0';
            this.ageForm.SelectedText = "";
            this.ageForm.SelectionLength = 0;
            this.ageForm.SelectionStart = 0;
            this.ageForm.Size = new System.Drawing.Size(167, 23);
            this.ageForm.TabIndex = 11;
            this.ageForm.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 163);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(34, 18);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Age";
            // 
            // companyForm
            // 
            this.companyForm.Depth = 0;
            this.companyForm.Hint = "Your Company ->-";
            this.companyForm.Location = new System.Drawing.Point(111, 197);
            this.companyForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.companyForm.Name = "companyForm";
            this.companyForm.PasswordChar = '\0';
            this.companyForm.SelectedText = "";
            this.companyForm.SelectionLength = 0;
            this.companyForm.SelectionStart = 0;
            this.companyForm.Size = new System.Drawing.Size(167, 23);
            this.companyForm.TabIndex = 13;
            this.companyForm.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 202);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(71, 18);
            this.materialLabel4.TabIndex = 12;
            this.materialLabel4.Text = "Company";
            // 
            // posForm
            // 
            this.posForm.Depth = 0;
            this.posForm.Hint = "Your Position )_(";
            this.posForm.Location = new System.Drawing.Point(111, 235);
            this.posForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.posForm.Name = "posForm";
            this.posForm.PasswordChar = '\0';
            this.posForm.SelectedText = "";
            this.posForm.SelectionLength = 0;
            this.posForm.SelectionStart = 0;
            this.posForm.Size = new System.Drawing.Size(167, 23);
            this.posForm.TabIndex = 15;
            this.posForm.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 240);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(64, 18);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Position";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 355);
            this.ControlBox = false;
            this.Controls.Add(this.posForm);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.companyForm);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.ageForm);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.SignUpCancelBtn);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.pwdForm);
            this.Controls.Add(this.accountForm);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUpForm";
            this.Text = "Sign Up";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField pwdForm;
        private MaterialSkin.Controls.MaterialSingleLineTextField accountForm;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button SignUpCancelBtn;
        private System.Windows.Forms.Button SignUpBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField ageForm;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField companyForm;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField posForm;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}