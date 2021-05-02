using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapoModel;

namespace ChapooDAL
{
    public class User_DAO : Base
    {
        //Check if user does exist.(login)
        public User GetUser(string userName, string password)
        {
            string query = "select [UserId], [UserName], [userPassword], [UserCode] from [User] where UserName = '" + userName + "' and   userPassword =  '" + password + "' ";
            return RetrieveUser(ExecuteSelectQuery(query));
        }
        //If user exist -> fill all the info
        private User RetrieveUser(DataTable dataTable)
        {
            int userId = 0;
            string userName = "";
            string userPassword = "";
            int userCode = 0;

            foreach (DataRow i in dataTable.Rows)
            {
                {
                    userId = (int)i["UserId"];
                    userName = (string)i["userName"];
                    userPassword = (string)i["userPassword"];
                    userCode = (int)i["UserCode"];
                    //userKey = (string)i["userKey"];
                };
            }
            return new User(userId, userName, userPassword, userCode);
            //return new User();
        }

   

    }
}