using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapoModel
{
    public class User
    {

        public int userId { get; set; }
        public string userName { get; set; }
        public int userCode { get; set; }
        public string userKey { get; set; }
        public string title { get; set; }
        public string userPassword { get; set; }

        public User(int UserId, string UserName, string Title, int UserCode, string UserKey, string UserPassword)
        {
            this.userId = UserId;
            this.userName = UserName;
            this.title = Title;
            this.userCode = UserCode;
            this.userKey = UserKey;
            this.userPassword = UserPassword;
        }
    }
}
