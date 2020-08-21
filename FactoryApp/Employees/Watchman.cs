﻿using FactoryApp.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryApp.Employees
{
    public class Watchman : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public UserRole Role { get { return UserRole.Watchman; } }
        public AccessBoundry Access { get; set; }

        internal Watchman(AccessBoundry access)
        {
            Access = access;
        }
        public void SetEmail()
        {
            var userName = EmployeeHelper.GetUserName(FirstName, LastName);

            Email = string.Format("{0}@sevurity.globant.com", userName);
        }

        public override string ToString()
        {
            var obj = $"Employee Details: {Environment.NewLine}";
            obj += $"User Role: {Role}, {Environment.NewLine}";
            obj += $"First name: {FirstName}, {Environment.NewLine}";
            obj += $"Last name: {LastName}, {Environment.NewLine}";
            obj += $"Email address: {Email}, {Environment.NewLine}";
            obj += $"User Type: {Access}.";
            return obj;
        }
    }
}
