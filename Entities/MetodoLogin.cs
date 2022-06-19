using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MetodoLogin
    {
        public MetodoLogin(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public string Login { get; set; }
        public string Password { get; set; }

        public string aLogin = "admin";
        public string apassword = "admin";

        public bool IsLoggedIn(MetodoLogin Login)
        {
            
            if (Login.Login == aLogin && Login.Password == apassword)
            {
                return true;
            }
            else return false;
        }


    }
}
