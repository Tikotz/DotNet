using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventsHMq5
{
    public delegate void LoginDelegate();
    public delegate void DepositDelegate();


    public class User
    {

        public string UserName { get; set; }
        public int Password { get; set; }
        public bool IsLoggedIn {  get; set; }
        public double MyMoney { get; set; }

        public User(string userName, int password)
        {
            UserName = userName;
            Password = password;
        }

        
    }
}
