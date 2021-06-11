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
        private User_Service user_Service = new User_Service();
        private List<User> UserLists = new List<User>();
        private AdminAllUsers adminAllUsers;


        public void GetAllUsersList(List<User> userLists)
        {
            this.UserLists = userLists;
            GetAllData();
        }
        public AdminCreateUser()
        {
            InitializeComponent();
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

                this.Hide();
                adminAllUsers = new AdminAllUsers();
                adminAllUsers.ShowDialog();
                this.Close();

            }
            else
                MessageBox.Show("please fill all the fields in.");
        }
        public void GetAllData()
        {
            string titel;
            List<string> userTitle = new List<string>();

            //Adding titles data form object to list
            foreach (var item in UserLists)
            {
                titel = item.title;
                if (!userTitle.Contains(titel))
                    userTitle.Add(item.title);
            }
            drop_UserRol.DataSource = userTitle;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
