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
using System.Data.SqlClient;
using System.Configuration;

namespace ChapooUI
{
    public partial class AdminAllUsers : Form
    {
        User_Service user_Service = new User_Service();
        List<User> userLists = new List<User>();
        private AdminChangePassword adminChangePassWord;
        private AdminCreateUser adminCreateUser;

        public AdminAllUsers()
        {
            InitializeComponent();
        }
        private void AdminAllUsers_Load_1(object sender, EventArgs e)
        {
            GetAllData();
        }
        //Get all data -> fill in lists
        public void GetAllData()
        {
            userLists = user_Service.getAllUsers();
            //Show data of all users
            dataGridView1.DataSource = userLists;
        }
        //Create User
        private void Btn_CreateUser_Click(object sender, EventArgs e)
        {
            adminCreateUser = new AdminCreateUser();
            adminCreateUser.GetAllUsersList(userLists);
            adminCreateUser.ShowDialog();
        }
        //Change Password
        private void Btn_ChangePassword_Click(object sender, EventArgs e)
        {
            adminChangePassWord = new AdminChangePassword();
            adminChangePassWord.GetUserList(userLists);
            adminChangePassWord.ShowDialog();
        }
        //Go back to login screen
        private void btn_BackAdminDasboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            login logindashboard = new login();
            logindashboard.ShowDialog();
            this.Close();
        }
    }
}
