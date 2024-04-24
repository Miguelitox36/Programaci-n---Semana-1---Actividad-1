using Semana_1___Actividad_1;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        EmployeeDatabase database = new EmployeeDatabase();

        
        Employee emp1 = new Employee("John Doe", 30);
        Manager manager1 = new Manager("Jane Smith", 35, "HR");

        
        database.AddEmployee(emp1);
        database.AddEmployee(manager1);

        
        Employee foundEmployee = database.GetEmployeeByName("John Doe");
        if (foundEmployee != null)
        {
            Console.WriteLine("Employee found:");
            foundEmployee.PrintDetails();
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }

        
        List<Employee> allEmployees = database.GetAllEmployees();
        Console.WriteLine("\nAll Employees:");
        foreach (Employee employee in allEmployees)
        {
            employee.PrintDetails();
        }
    }
}