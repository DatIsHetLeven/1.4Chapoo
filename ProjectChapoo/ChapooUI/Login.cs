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
    public partial class login : Form
    {
        private Dashboard Dashboard;
        private AdminDashboard adminDashboard;
        private BarKitchenDashboard BarKitchenDashboard;
        private User_Service user_Service = new User_Service();
        public login()
        {
            InitializeComponent();
        }

        //Buttin inloggen
        private void btn_Inloggen_Click_1(object sender, EventArgs e)
        {
            //Check if username and password are not empty.
            if (txt_LoginUsername.Text != "" && txt_LoginPassword.Text != "")
            {
                string userName = txt_LoginUsername.Text;
                string password = txt_LoginPassword.Text;
                User user = user_Service.GetUser(userName, password);
                //If user exist
                if (user.userName != "")
                {
                    //If Admin
                    if (user.userCode == 3)
                    {
                        this.Hide();
                        adminDashboard = new AdminDashboard();
                        adminDashboard.ShowDialog();
                        this.Close();
                    }
                    //If bediende 
                    else if (user.userCode == 1)
                    {
                        this.Hide();
                        Dashboard = new Dashboard();
                        Dashboard.DashboardUser(user);
                        Dashboard.ShowDialog();
                        this.Close();
                    }
                    //if barman
                    else
                    {
                        this.Hide();
                        BarKitchenDashboard = new BarKitchenDashboard(user);
                        BarKitchenDashboard.ShowDialog();
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("error occured : User does not exist");
            }
            //If at least on field is empty -> show error.
            else
                MessageBox.Show("Error occured : Username and/ or Password is empty!");
            //Clear both fields after not succeeded.
            txt_LoginPassword.Clear();
            txt_LoginUsername.Clear();
        }

        //button reset password
        private void btn_resetPsswrd_Click(object sender, EventArgs e)
        {
                this.Hide();
                ResetPassword resetPassword = new ResetPassword();
                resetPassword.ShowDialog();
                this.Close();
        }
    }
}
