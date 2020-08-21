using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryApp.Helper
{
    public static class EmployeeHelper
    {
        public static string GetUserName(string firstName, string lastName)
        {
            var initialFirstName = firstName.Replace(" ", ".").Split(".")[0].ToLower();
            var initialLastName = lastName.Replace(" ", ".").Split(".")[0].ToLower();
            return string.Join(".", initialFirstName, initialLastName);
        }
    }
}
