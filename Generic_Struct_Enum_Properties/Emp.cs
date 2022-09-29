using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Struct_Enum_Properties
{
    //Generic class
    class Emp<type>
    {
        string name;
        type salary = default;

        public Emp() { } //no error

        public Emp(string name, type salary)
        {
            this.name = name;
            this.salary = salary;
        }




        //properties
        public string Name { get => name; set => name = value; } 
        public type Salary { get => salary; set => salary = value; }

        public void Print() {
            Console.WriteLine($"Employee name is {name} And his salary is ={salary}");
        
        }
    }
}
