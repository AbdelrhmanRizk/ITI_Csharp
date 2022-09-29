using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesTask
{
    class BankAccount
    {
        String name;
        int id;
        float blance;

        public BankAccount(string name, int id, float blance)
        {
            this.name = name;
            this.id = id;
            this.blance = blance;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public float Blance { get => blance; set => blance = value; }


        public  void deposit(float desValue, float blance)
        {
            Console.WriteLine($"THE NEW BLANCE IS {desValue + blance}");
        }

        public void withDrawal(float blance,float witValue)
        {
            Console.WriteLine($"THE NEW BLANCE IS {blance - witValue}");
        }





    }
}
