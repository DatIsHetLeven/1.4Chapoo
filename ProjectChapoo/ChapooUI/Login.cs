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
        User_Service user_Service = new User_Service();
        public login()
        {
            InitializeComponent();
        }


        //Buttin inloggen
        private void btn_Inloggen_Click_1(object sender, EventArgs e)
        {
            //if (txt_LoginUsername.Text == "aa")
            //{
            //    this.Hide();
            //    AdminDashboard adminDashboard = new AdminDashboard();
            //    adminDashboard.ShowDialog();
            //    this.Close();
            //}

            //if (txt_LoginUsername.Text == "a")
            //{
            //    this.Hide();
            //    BarKitchenDashboard barKitchenDashboard = new BarKitchenDashboard();
            //    barKitchenDashboard.ShowDialog();
            //    this.Close();
            //}
            //else
            //{
            //    this.Hide();
            //    Dashboard dashboardVieww = new Dashboard();
            //    dashboardVieww.ShowDialog();
            //    this.Close();
            //}


            //Check if username and password are not empty.\
            if (txt_LoginUsername.Text != "" && txt_LoginPassword.Text != "")
            {
                string userName = txt_LoginUsername.Text;
                string password = txt_LoginPassword.Text;
                User user = user_Service.GetUser(userName, password);
                //If user exist
                if (user.userName != "")
                {
                    //If user is Admin
                    if (user.userCode == 3)
                    {
                        this.Hide();
                        AdminDashboard adminDashboard = new AdminDashboard(user);
                        adminDashboard.ShowDialog();
                        this.Close();
                    }
                    //If server
                    else if (user.userCode == 1)
                    {
                        this.Hide();
                        Dashboard dashboardView = new Dashboard(user);
                        dashboardView.ShowDialog();
                        this.Close();
                    }
                    //if barman
                    else
                    {
                        this.Hide();
                        BarKitchenDashboard barKitchenDashboard = new BarKitchenDashboard(user);
                        barKitchenDashboard.ShowDialog();
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
