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
        private User User;
        public AdminAllUsers(User user)
        {
            InitializeComponent();
            this.User = user;
        }
        private void AdminAllUsers_Load_1(object sender, EventArgs e)
        {
            GetAllData();
        }
        //Get all data -> fill in lists
        public void GetAllData()
        {
            //Create object list of userlist
            userLists = user_Service.getAllUsers();
            //Show data of all users
            dataGridView1.DataSource = userLists;
        }
        //Create User
        private void Btn_CreateUser_Click(object sender, EventArgs e)
        {
            AdminCreateUser adminCreateUser = new AdminCreateUser(User);
            adminCreateUser.ShowDialog();
        }
        //Change Password
        private void Btn_ChangePassword_Click(object sender, EventArgs e)
        {
            AdminChangePassword adminChangePassword = new AdminChangePassword(User);
            adminChangePassword.ShowDialog();
        }
        //Go back to dashboard
        private void btn_BackAdminDasboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard(User);
            adminDashboard.ShowDialog();
            this.Close();
        }


    }
}
