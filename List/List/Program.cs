using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> s1 = new List<Student> (4);
            s1.Add(new Student() { Id = 10, Name = "Abdo", Age = 23 });
            s1.Add(new Student() { Id = 20, Name = "Ammar", Age = 10 });
            s1.Add(new Student() { Id = 30, Name = "sara", Age = 30 });
            s1.Add(new Student() { Id = 40, Name = "Amal", Age = 5 });

            foreach(var item in s1)
                Console.WriteLine(item);
            Console.WriteLine("------------------");


            List<Student> r1 = s1.FindAll((s)=> s.Age>20 && s.Age<30);
            foreach(var item in r1)
                Console.WriteLine(item);
            Console.WriteLine("--------------------");


            r1 = s1.FindAll((s) => s.Name.Length >= 5 );
            foreach (var item in r1)
                Console.WriteLine(item);
            Console.WriteLine("--------------------");

            r1 = s1.FindAll((s) => s.Name.Contains("a"));
            foreach (var item in r1)
                Console.WriteLine(item);
            Console.WriteLine("--------------------");



            List<String> studentName = new List<String>(4);
            studentName.Add("Abdo");
            studentName.Add("Ammar");
            studentName.Add("Rizk");
            studentName.Add("Sara");

            foreach (var item in studentName)
                Console.WriteLine(item);
            Console.WriteLine("------------------");

            List<String> r2 = studentName.FindAll((s) => s.Length >3);
            foreach (var item in r2)
                Console.WriteLine(item);
            Console.WriteLine("--------------------");

            r2 = studentName.FindAll((s) => s.Contains("a"));
            foreach (var item in r2)
                Console.WriteLine(item);
            Console.WriteLine("--------------------");

            r2 = studentName.FindAll((s) => s.EndsWith("a"));
            foreach (var item in r2)
                Console.WriteLine(item);
            Console.WriteLine("--------------------");















            Console.ReadKey();
        }
    }
}
