using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class MemberShip
    {
        public delegate void LoginAction(string email);
        public event LoginAction LoginEvent;
        public void Login(string email, string password)
        {
            if (LoginEvent != null)
                LoginEvent(email);

        }
        public void SignUp(string email, string password, string confirmpassword)
        {
        
        }
    }
}
