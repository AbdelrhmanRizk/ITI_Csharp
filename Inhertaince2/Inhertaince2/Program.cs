using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertaince2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human(name:"Abdo Rizk",age:23,id:299);
            h1.print();
            Console.WriteLine();
       

            Student s1 = new Student(name: "Abdo Rizk", age: 23, id: 299,grade:"Very Good");
            s1.print();
            Console.WriteLine();
           

            Emp e1 = new Emp(name: "Abdo Rizk", age: 23, id: 299, salary:5000);
            e1.print();
            Console.ReadKey();




        }
    }
}
