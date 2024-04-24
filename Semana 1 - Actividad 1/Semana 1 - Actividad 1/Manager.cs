using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_1___Actividad_1
{
    public class Manager : Employee
    {
        public string Department { get; set; }
                
        public Manager(string name, int age, string department) : base(name, age)
        {
            Department = department;
        }
                
        public override void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Department: {Department}");
        }
    }
}
