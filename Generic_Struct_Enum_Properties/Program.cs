using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Struct_Enum_Properties
{
     //Department Enum 
    enum FICSDepartment{
        CS,IS,IT,Bioinformatics,Software
    
    }




    class Program
    {

        
        static void Main(string[] args)
        {

            FICSDepartment stud1 = FICSDepartment.Bioinformatics;
            Console.WriteLine(stud1);
            stud1 =(FICSDepartment) 1; //second position
            Console.WriteLine(stud1);
            Console.WriteLine();


            Emp<double> e1 = new Emp<double>("Abdo Rizk",5000.5);
            e1.Print();
            Console.WriteLine();


            Point p1 = new Point(10, 20);
            Point p2 = new Point(30, 40);
            p1 = p2;
            p1.Print();
            p2.X = 50;
            p1.Print(); // No change in p1 (Because structs are value type)
            Console.WriteLine();


            int i1 =5;
            int i2 = 10;
            Swap(ref i1,ref i2);

            float f1 = 5.5f;
            float f2 = 10.5f;
            Swap(ref f1, ref f2);



           
        }

        //generic method
        public static void Swap<type>(ref type a, ref type b) {
            type temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"{a}:{b}");
            Console.ReadKey();
        
        
        }
    }
}
