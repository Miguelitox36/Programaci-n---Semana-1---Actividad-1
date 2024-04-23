using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_1___Actividad_1
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }
                
        public virtual void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
