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
    public partial class AdminChangePassword : Form
    {
        User_Service user_Service = new User_Service();
        private User User;
        public AdminChangePassword(User user)
        {
            InitializeComponent();
            this.User = user;
            GetAllData();
        }
        private void btn_AddPrivateKey_Click(object sender, EventArgs e)
        {
            int userId = (drop_UserId.SelectedIndex + 1);
            string privateKey = txt_PrivateKey.Text;
            if (privateKey != "")
            {
                user_Service.createPrivateKey(privateKey, userId);
                txt_PrivateKey.Clear();

                this.Hide();
                AdminAllUsers admin = new AdminAllUsers(User);
                admin.ShowDialog();
                this.Close();
                GetAllData();
            }
            else
                MessageBox.Show("Please fill in the PrivateKey");
        }
        public void GetAllData()
        {
            //Create object list of userlist
            List<User> userLists = new List<User>();
            userLists = user_Service.getAllUsers();
            //List of items you want
            List<int> userID = new List<int>();
            //Adding specifiek data form object to list
            foreach (var item in userLists)
                userID.Add(item.userId);

            drop_UserId.DataSource = userID;
        }
    }
}
