using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryApp.Employees
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        UserRole Role { get; }
        AccessBoundry Access { get; set; }
        void SetEmail();
    }
}
