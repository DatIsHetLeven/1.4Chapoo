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
    public partial class AdminCreateUser : Form
    {
        User_Service user_Service = new User_Service();
        private User User;
        public AdminCreateUser(User user)
        {
            InitializeComponent();
            this.User = user;
            GetAllData();
        }

        private void btn_CreateNewUser_Click(object sender, EventArgs e)
        {
            string userName = txt_NewUserName.Text;
            string password = txt_UserPassword.Text;
            string rol = drop_UserRol.Text;
            int userRol = 1;

            if (userName != "" && password != "")
            {
                if (rol == "Barman")
                    userRol = 2;
                else if (rol == "Admin")
                    userRol = 3;

                user_Service.createUser(userName, password, userRol);
                MessageBox.Show("User has been created");
                txt_NewUserName.Clear();
                txt_UserPassword.Clear();

                this.Hide();
                AdminAllUsers admin = new AdminAllUsers(User);
                admin.ShowDialog();
                this.Close();

            }
            else
                MessageBox.Show("please fill all the fields in.");
        }
        public void GetAllData()
        {
            string titel;

            List<User> userLists = new List<User>();
            userLists = user_Service.getAllUsers();
            List<string> userTitle = new List<string>();
            //Adding specifiek data form object to list
            foreach (var item in userLists)
            {
                titel = item.title;
                if (!userTitle.Contains(titel))
                    userTitle.Add(item.title);
            }
            drop_UserRol.DataSource = userTitle;
        }
    }
}
