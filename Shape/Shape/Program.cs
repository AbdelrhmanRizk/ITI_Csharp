using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Triangle t1 = new Triangle(5,10);
            t1.Print();
            Console.WriteLine();

            Triangle t2 = new Triangle(0, -10);
            t2.Print();
            Console.WriteLine();

            Triangle t3 = new Triangle(0, 5);
            t3.Print();
            Console.WriteLine();




            Rectangle r1 = new Rectangle(5, 10);
            r1.Print();
            Console.WriteLine();

            Rectangle r2 = new Rectangle(-5, 0);
            r2.Print();
            Console.WriteLine();

            Rectangle r3 = new Rectangle(0, 5);
            r3.Print();
            Console.WriteLine();



            Console.ReadKey();


        }
    }
}
