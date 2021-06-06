using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;
using ChapoModel;

namespace ChapooUI
{
    public partial class ResetPassword : Form
    {
        User_Service User_Service = new User_Service();
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
            this.Close();
        }

        private void btn_ResetPassword_Click(object sender, EventArgs e)
        {
            List<User> userList = new List<User>();
            userList = User_Service.getAllUsers();
            bool checkUserKey = false;

            string userKey = txtUserKey.Text.ToString();
            foreach (var item in userList)
            {
                if (item.userKey == userKey)
                {
                    checkUserKey = true;
                    break;
                }
            }

            string password = txtPassword.Text;
            int userId = int.Parse(txtUserId.Text);

            //string existUserKey = userList.Contains("");
            if (userKey != "" || password != "" || userId != 0)
            {
                if (txtPassword.Text == txtVerifyPassword.Text)
                {
                    if (checkUserKey)
                    {
                        User_Service.ResetPassword(userKey, userId, password);
                        MessageBox.Show("Password changed successfully");
                    }
                    else
                        MessageBox.Show("UserKey is not correct!");
                }
                else
                    MessageBox.Show("Password does not match");
            }
            else
                MessageBox.Show("Fill in all the fields please");
            txtUserId.Clear();
            txtPassword.Clear();
            txtUserKey.Clear();
            txtVerifyPassword.Clear();
        }
    }
}
