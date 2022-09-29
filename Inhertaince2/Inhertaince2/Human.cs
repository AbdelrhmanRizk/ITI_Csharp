using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertaince2
{
    class Human
    {
        protected  string name;
        protected int id;
        protected int age;

        public Human(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }

        public  void print() {
            Console.WriteLine($"name:{name} age:{age} id:{id}");
        
        
        }
    }
}
