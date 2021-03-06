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
        int userId = 0;
        string userName = "";
        string userPassword = "";
        UserTitle userTitle;
        int userCode = 0;
        string userKey = "";
        //Check if user does exist.(login)
        public User GetUser(string userName, string password)
        {
            string query = "select [UserId], [UserName], [userPassword], [UserCode], [userKey], [Title] from [User],[UserRol] where [UserRol].[Rol_Id] = [user].[userCode] and UserName = '" + userName + "' and   userPassword =  '" + password + "' ";
            return RetrieveUser(ExecuteSelectQuery(query));
        }
        //If user exist -> fill all the info
        private User RetrieveUser(DataTable dataTable)
        {
            User user = null;

            if (dataTable.Rows.Count ==1)
            {
                DataRow dataRow = dataTable.Rows[0];
                userId = (int)dataRow["UserId"];
                userName = (string)dataRow["userName"];
                userTitle = (UserTitle)Enum.Parse(typeof(UserTitle), (string)dataRow["Title"]);
                userCode = (int)dataRow["UserCode"];
                userKey = (string)dataRow["userKey"];
                userPassword = (string)dataRow["userPassword"].ToString();

                user = new User(userId, userName, userTitle, userCode, userKey, userPassword);
            }
            return user;
        }
        ////Create new user /Insert new user in db
        //public void InserNewUser(string userName, string password, int rol)
        //{
        //    string query = $"Insert into [User] (userName, userPassword, UserCode) Values('{userName}', '{password}', '{rol}')";
        //    ExecuteEditQuery(query);
        //}
        ////Create private key -> so user can reset password.
        //public void InsertPrivateKey(string privateKey, int userId)
        //{
        //    string query = $"update [user]set userKey='{privateKey}' where userid='{userId}'";
        //    ExecuteEditQuery(query);
        //}
        ////Reset password by User
        //public void ResetPassword(string privateKey, int userId, string Password)
        //{
        //    string query = $"update [user] set [userPassword] = '{Password}' where [userId]= '{userId}' AND [userKey] ='{privateKey}' ";
        //    ExecuteEditQuery(query);
        //}
        ////Return List of players -> Admin panel.
        //public List<User> getAllUsers()
        //{
        //    string query = "select [UserId], [UserName], [title], [UserCode], [userKey] from [User], [UserRol] where userCode = Rol_Id Order By [userId]";
        //    return RetrieveAllUsersList(ExecuteSelectQuery(query));
        //}
        ////Return users values for list(admin page)
        //private List<User> RetrieveAllUsersList(DataTable dataTable)
        //{
        //    List<User> UserList = new List<User>();
        //    foreach (DataRow dr in dataTable.Rows)
        //    {
        //        userId = (int)dr["UserId"];
        //        userName = (string)dr["userName"].ToString();
        //        title = (string)dr["title"].ToString();
        //        userCode = (int)dr["UserCode"];
        //        userKey = (string)dr["userKey"].ToString();
        //        User user = new User(userId, userName, title, userCode, userKey, userPassword);
        //        UserList.Add(user);
        //    }
        //    return UserList;
        //}
    }
}