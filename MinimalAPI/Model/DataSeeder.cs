﻿namespace MinimalAPI.Model
{
    public class DataSeeder
    {
        private readonly EmployeeDbContext employeeDbContext;

        public DataSeeder(EmployeeDbContext employeeDbContext)
        {
            this.employeeDbContext = employeeDbContext;
        }

        public void Seed()
        {
            if (!employeeDbContext.Employee.Any())
            {
                var employees = new List<Employee>()
                {
                    new Employee()
                    {
                        Name = "Tulasi",
                        Citizenship = "India",
                        EmployeeId = "1"
                    },
                    new Employee()
                    {
                        Name = "Swathi",
                        Citizenship = "England",
                        EmployeeId = "2"
                    }
                };

                employeeDbContext.Employee.AddRange(employees);
                employeeDbContext.SaveChanges();
            }
        }
    }
}
