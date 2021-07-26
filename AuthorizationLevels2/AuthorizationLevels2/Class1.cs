using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationLevels2
{
    public class user
    {
        //static fields
        public static user[] users = new user[3];
        //{
        //    //new user
        //    //{
        //    //    userName = "1",
        //    //    password = "1",
        //    //    permission = "admin",
        //    //    isLogin = false
        //    //},
        //    //new user
        //    //{
        //    //    userName = "2",
        //    //    password = "2",
        //    //    permission = "admin",
        //    //    isLogin = false
        //    //},
        //    //new user
        //    //{
        //    //    userName = "3",
        //    //    password = "3",
        //    //    permission = "admin",
        //    //    isLogin = false
        //    //},
        //};

        //instance fields
        public string userName;
        public string password;
        public bool isLogin;
        public string permission;


        public static string Login(string userName, string password)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (userName.ToLower() == users[i].userName.ToLower() && password.ToLower() == users[i].password.ToLower())
                {
                    users[i].isLogin = true;
                    return users[i].permission;
                }
            }

            return null;
        }

        public static string Logout(string userName, string password)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (userName.ToLower() == users[i].userName.ToLower() && password.ToLower() == users[i].password.ToLower())
                {
                    users[i].isLogin = false;
                    return users[i].permission;
                }
            }

            return null;
        }
    }
}
