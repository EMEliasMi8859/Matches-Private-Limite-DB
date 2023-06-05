namespace MatchesFirmDataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginLbl = new System.Windows.Forms.Label();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.LoginMsg = new System.Windows.Forms.Label();
            this.ShowPasswordChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LoginLbl
            // 
            this.LoginLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginLbl.Location = new System.Drawing.Point(85, 77);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(207, 30);
            this.LoginLbl.TabIndex = 0;
            this.LoginLbl.Text = "Login to system";
            this.LoginLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLbl.Location = new System.Drawing.Point(61, 138);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(85, 21);
            this.UserNameLbl.TabIndex = 0;
            this.UserNameLbl.Text = "User name";
            this.UserNameLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.UserNameTxt.Location = new System.Drawing.Point(65, 163);
            this.UserNameTxt.Margin = new System.Windows.Forms.Padding(6);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(253, 29);
            this.UserNameTxt.TabIndex = 1;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Silver;
            this.LoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginBtn.Location = new System.Drawing.Point(145, 352);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(98, 41);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(61, 216);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(77, 21);
            this.PasswordLbl.TabIndex = 0;
            this.PasswordLbl.Text = "Password";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordTxt.Location = new System.Drawing.Point(65, 241);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(253, 26);
            this.PasswordTxt.TabIndex = 2;
            this.PasswordTxt.UseSystemPasswordChar = true;
            this.PasswordTxt.TextChanged += new System.EventHandler(this.PasswordTxt_TextChanged);
            this.PasswordTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTxt_KeyDown);
            // 
            // LoginMsg
            // 
            this.LoginMsg.AutoSize = true;
            this.LoginMsg.BackColor = System.Drawing.Color.Transparent;
            this.LoginMsg.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.LoginMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoginMsg.Location = new System.Drawing.Point(61, 297);
            this.LoginMsg.Name = "LoginMsg";
            this.LoginMsg.Size = new System.Drawing.Size(0, 18);
            this.LoginMsg.TabIndex = 0;
            this.LoginMsg.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // ShowPasswordChk
            // 
            this.ShowPasswordChk.AutoSize = true;
            this.ShowPasswordChk.Location = new System.Drawing.Point(65, 273);
            this.ShowPasswordChk.Name = "ShowPasswordChk";
            this.ShowPasswordChk.Size = new System.Drawing.Size(101, 17);
            this.ShowPasswordChk.TabIndex = 4;
            this.ShowPasswordChk.Text = "Show password";
            this.ShowPasswordChk.UseVisualStyleBackColor = true;
            this.ShowPasswordChk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.ShowPasswordChk);
            this.Controls.Add(this.LoginMsg);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.LoginLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matches firm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLbl;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label LoginMsg;
        private System.Windows.Forms.CheckBox ShowPasswordChk;
    }
}