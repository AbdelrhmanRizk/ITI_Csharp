using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex C1 = new Complex(3,5);
            Complex C2 = new Complex(5, 10);
            Complex C3 = new Complex(15, 20);
            C3.print();
            Console.WriteLine(Complex.Count);
            Console.ReadKey();

        }
    }
}
