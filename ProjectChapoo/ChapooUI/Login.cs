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
    public partial class Login : Form
    {
        User_Service user_Service = new User_Service();
        public Login()
        {
            InitializeComponent();
        }

        //Button inloggen
        private void btn_Inloggen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboardView = new Dashboard();
            dashboardView.ShowDialog();
            this.Close();

            ////Check if username and password are not empty.
            //if (txt_LoginUsername.Text != "" && txt_LoginPassword.Text != "")
            //{
            //    string userName = txt_LoginUsername.Text;
            //    string password = txt_LoginPassword.Text;
            //    User user = user_Service.GetUser(userName, password);
            //    //If user exist
            //    if (user.userName != "")
            //    {
            //        this.Hide();
            //        Dashboard dashboardView = new Dashboard();
            //        dashboardView.ShowDialog();
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("error occured : User does not exist");
            //    }
            //}
            ////If at least on field is empty -> show error.
            //else
            //{
            //    MessageBox.Show("Error occured : Username and/ or Password is empty!");
            //}
            ////Clear both fields after not succeeded.
            //txt_LoginPassword.Clear();
            //txt_LoginUsername.Clear();
        }
    }
}
