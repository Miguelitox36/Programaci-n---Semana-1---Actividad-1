using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_1___Actividad_1
{
    public class IEmployeeDatabase
    {        
        void AddEmployee(Employee employee);
        Employee GetEmployeeByName(string name);
        List<Employee> GetAllEmployees();
    }
}
