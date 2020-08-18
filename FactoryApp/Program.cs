using FactoryApp.Employees;
using System;
using System.Threading.Tasks;

namespace FactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = EmployeeFactory.GetEmployeeInstance(UserRole.Developer, AccessBoundry.User);
            employee.FirstName = "Camilo A";
            employee.LastName = "Villa Naranjo";
            employee.SetEmail();

            Console.WriteLine(employee);
            Console.ReadKey();
        }
    }
}
