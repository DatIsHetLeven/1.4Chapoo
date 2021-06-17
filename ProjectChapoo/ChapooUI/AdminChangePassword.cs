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
        private AdminAllUsers admin;
        private User_Service user_Service = new User_Service();
        private List<User> userLists = new List<User>();
        List<int> userID = new List<int>();

        public void GetUserList(List<User>UserLists)
        {
            this.userLists = UserLists;
            GetAllData();
        }
        public AdminChangePassword()
        {
            InitializeComponent();
        }
        private void btn_AddPrivateKey_Click(object sender, EventArgs e)
        {
            int userId = (drop_UserId.SelectedIndex + 1);
            string privateKey = txt_PrivateKey.Text;
            if (privateKey != "")
            {
               // user_Service.createPrivateKey(privateKey, userId);
                txt_PrivateKey.Clear();
                this.Hide();
                admin = new AdminAllUsers();
                admin.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Please fill in the PrivateKey");
        }
        public void GetAllData()
        {
            foreach (var item in userLists)
                userID.Add(item.userId);

            drop_UserId.DataSource = userID;
        }
    }
}
