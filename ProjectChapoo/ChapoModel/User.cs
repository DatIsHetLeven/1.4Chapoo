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
        public string userPassword { get; set; }
        public int userCode { get; set; }

        public User(int UserId, string UserName, string UserPassword, int UserCode)
        {
            this.userId = UserId;
            this.userName = UserName;
            this.userPassword = UserPassword;
        }
    }
}
