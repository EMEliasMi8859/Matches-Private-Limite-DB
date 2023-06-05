using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
namespace MatchesFirmDataBase
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#001D50");
            this.ForeColor = ColorTranslator.FromHtml("#FA6915");
            this.LoginLbl.ForeColor = ColorTranslator.FromHtml("#FA6915");
            this.UserNameTxt.BackColor = ColorTranslator.FromHtml("#151D39");
            this.UserNameTxt.ForeColor = ColorTranslator.FromHtml("#fff");
            this.UserNameTxt.BorderStyle = ColorTranslator.FromHtml("#2B273B");
        }
        private bool Authenticated = false;
        private string LoginUsername = "username";
        private string LoginPassword = "pass123";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Authentication();
        }
        private void Authentication()
        {

            if (UserNameTxt.Text == LoginUsername && PasswordTxt.Text == LoginPassword)
            {
                this.Close();
                Authenticated = true;
            }
            else
            {
                LoginMsg.Text = "Username or password wasn't recognized!";
            }
        }
        public bool isAuthenticated()
        {
            return Authenticated;
        }
        public void setAuthentication(bool auth)
        {
            Authenticated = auth;
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn.PerformClick();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTxt.UseSystemPasswordChar = !ShowPasswordChk.Checked;
        }

        private void changeLoginInfo_Click(object sender, EventArgs e)
        {

            Authentication();
            if (isAuthenticated())
            {
                System.Windows.Forms.MessageBox.Show("this is a message");
/*
                LoginForm LoginInfoForm = new LoginForm();
                MessageBox.Show("message");
                LoginInfoForm.ShowDialog();*/
                Authenticated = false;
            }
        }
    }
}
