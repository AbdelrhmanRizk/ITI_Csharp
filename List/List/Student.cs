using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Student
    {
        string name;
        int age;
        int id;

        

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return $"{id}:{name}:{age}";
        }




    }
}
