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



    }
}
