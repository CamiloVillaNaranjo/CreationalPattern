namespace FactoryApp.Employees
{
    public static class EmployeeFactory
    {
        public static IEmployee GetEmployeeInstance(UserRole role, AccessBoundry access)
        {
            IEmployee employee = new Employee(access);
            switch (role)
            {
                case UserRole.Director:
                    employee = new Director(access);
                    break;
                case UserRole.Manager:
                    employee = new Manager(access);
                    break;
                case UserRole.Executive:
                    employee = new Executive(access);
                    break;
                case UserRole.SalesPerson:
                    employee = new SalesPerson(access);
                    break;
                case UserRole.Secretary:
                    employee = new Secretary(access);
                    break;
                case UserRole.Developer:
                    employee = new Developer(access);
                    break;
                case UserRole.Watchman:
                    employee = new Watchman(access);
                    break;
                case UserRole.General:
                    employee = new Employee(access);
                    break;
            }
            return employee;
        }
    }
}
