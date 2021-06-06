using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;
using ChapoModel;

namespace ChapooUI
{
    public partial class AdminDashboard : Form
    {
        private AdminAllUsers adminAllUsers;
        private login login;
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btn_all_users_Click(object sender, EventArgs e)
        {
            adminAllUsers = new AdminAllUsers();
            this.Hide();
            adminAllUsers.ShowDialog();
            this.Close();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            login = new login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
