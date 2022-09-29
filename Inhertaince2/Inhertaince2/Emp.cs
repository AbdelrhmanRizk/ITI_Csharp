using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertaince2
{
    class Emp:Human
    {
        double salary;

        public Emp(string name, int id, int age, double salary) : base(name, id, age)
        {
            this.salary = salary;
        }
        public new void print()
        {
            base.print();
            Console.WriteLine($"salary:{salary}");


        }
    }
}
