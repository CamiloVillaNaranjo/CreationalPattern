using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryApp
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private User(string firstName, string lastName, string userName, string emailUser, string userPass)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Email = emailUser;
            Password = userPass;
        }

        public static class Factory { 
            public static User CreateUserByDefault(string firstName, string lastName)
            {
                var initialFirstName = firstName.Replace(" ", ".").Split(".")[0].ToLower();
                var initialLastName = lastName.Replace(" ", ".").Split(".")[0].ToLower();
                var userName = string.Join(".", initialFirstName, initialLastName);
                var defaultEmail = string.Format("{0}@globant.com", userName);
                var defaultPass = "C4Mbi4m3";

                return new User(firstName, lastName, userName, defaultEmail, defaultPass);
            }

            public static User CreateNewUser(string firstName, string lastName, string userPass)
            {
                var initialFirstName = firstName.Replace(" ", ".").Split(".")[0].ToLower();
                var initialLastName = lastName.Replace(" ", ".").Split(".")[0].ToLower();
                var userName = string.Join(".", initialFirstName, initialLastName);
                var emailUser = string.Format("{0}@globant.com", userName);

                return new User(firstName, lastName, userName, emailUser, userPass);
            }
        }
    }
}
