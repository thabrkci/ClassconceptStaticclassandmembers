using System;

namespace ClassconceptStaticclassandmembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Static Class and Members********");
            
            // Display the initial count of employees
            Console.WriteLine("Number of Employees: {0}", Employee.EmployeeCount);

            // Create an employee instance using the constructor
            Employee employee = new Employee("Taha", "BÖREKCİ", "HR");

            // Display the count of employees after creating an instance
            Console.WriteLine("Number of Employees: {0}", Employee.EmployeeCount);

            // Create another employee instance
            Employee worker = new Employee("John", "DOE", "DEPARTMENT");
      
            // Display the count of employees again
            Console.WriteLine("Number of Employees: {0}", Employee.EmployeeCount);
        }
    }

    class Employee
    {
        private static int employeeCount; // Static field to keep track of the number of employees

        // Public property to expose the employee count
        public static int EmployeeCount { get => employeeCount; }

        private string Name;
        private string Surname;
        private string Department;

        // Static constructor to initialize static members
        static Employee()
        {
            employeeCount = 0;
        }

        // Parameterized constructor to create an employee and increment the count
        public Employee(string name, string surname, string department)
        { 
            this.Name = name;
            this.Surname = surname;
            this.Department = department;
            employeeCount++; // Increment the count when a new employee is created
        }
    }
}
