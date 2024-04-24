using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_1___Actividad_1
{
    public class EmployeeDatabase : IEmployeeDatabase
    {
        private Dictionary<string, Employee> employees = new Dictionary<string, Employee>();
                
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee.Name, employee);
        }

        public Employee GetEmployeeByName(string name)
        {
            if (employees.ContainsKey(name))
                return employees[name];
            else
                return null;
        }

        public List<Employee> GetAllEmployees()
        {
            return new List<Employee>(employees.Values);
        }
    }
}
