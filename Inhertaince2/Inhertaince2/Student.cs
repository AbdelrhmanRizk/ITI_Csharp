using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertaince2
{
    class Student:Human
    {
        string grade;

        public Student(string name, int id, int age, string grade) : base(name, id, age)
        {
            this.grade = grade;
        }

        public string Grade { get => grade; set => grade = value; }

        public new void print()
        {
            base.print();
            Console.WriteLine($"grade:{grade}");


        }
    }
}
