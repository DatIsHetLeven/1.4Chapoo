using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Data;
using ChapooDAL;
using ChapoModel;

namespace ChapooLogic
{
    public class User_Service
    {
        User_DAO user_DAO = new User_DAO();
        public User GetUser(string userName, string password)
        {
            return user_DAO.GetUser(userName, password);
        }
        ////Create new user -> insert db
        //public void createUser(string userName, string password, int rol)
        //{
        //    user_DAO.InserNewUser(userName, password, rol);
        //}
        ////Create private Key -> to reset password.
        //public void createPrivateKey(string privateKey, int userId)
        //{
        //    user_DAO.InsertPrivateKey(privateKey, userId);
        //}
        //public List<User> getAllUsers()
        //{
        //    List<User> userList;
        //    userList = user_DAO.getAllUsers();
        //    return userList;
        //}
        ////Reset Password
        //public void ResetPassword(string privateKey, int userId, string Password)
        //{
        //    user_DAO.ResetPassword(privateKey, userId, Password);
        //}
    }
}

