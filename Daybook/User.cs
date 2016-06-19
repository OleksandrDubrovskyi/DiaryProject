using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daybook
{
    class User
    {
        string username;
        string password;

        public User(string username)
        {
            this.username = username;
        }

        public void setPassword()
        {
            while (true)
            {
                Console.WriteLine("Please, choose your password.");
                string tempPassword = Console.ReadLine();
                Console.WriteLine("Please, repeat your password.");
                string anotherPassword = Console.ReadLine();
                if (tempPassword == anotherPassword)
                {
                    this.password = tempPassword;
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, you entered different passwords." +
                        " Press Enter to continue.");
                    Console.ReadLine();
                }                  
            }
        }

        public bool checkUser(string username)
        {/*
            if (User exists)
            {
                return true;
            }*/
            return false;
        }

        public bool checkPassword(string password)
        {
            return false;
        }
    }
}
