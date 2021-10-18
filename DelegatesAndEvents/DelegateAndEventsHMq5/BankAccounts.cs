using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventsHMq5
{
    public static class BankAccounts
    {
        public static double BankMoney { get; set; }

        public static List<User> bankAccounts = new List<User>()
        { new User("ori", 123),
            new User("oritiko", 234),
            new User("avichi", 345),
            new User("lior", 456),
            new User("alon", 567)
        };
    }
}
