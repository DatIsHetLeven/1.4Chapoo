using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapoModel
{
    public class User
    {
        private int userid;


        public int userId { get { return userid; } }
        public string userName { get; set; }
        public int userCode { get; set; }
        public string userKey { get; set; }
        public UserTitle userTitle { get; set; }
        public string userPassword { get; set; }

        public User(int UserId, string UserName, UserTitle UserTitle, int UserCode, string UserKey, string UserPassword)
        {
            this.userid = UserId;
            this.userName = UserName;
            this.userTitle = UserTitle;
            this.userCode = UserCode;
            this.userKey = UserKey;
            this.userPassword = UserPassword;
        }
    }
}
