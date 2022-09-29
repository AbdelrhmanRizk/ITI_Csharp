using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Complex
    {
        int real;
        int img;
        static int count;

        public Complex(int real=0 , int img=0)
        {
            count++;
            this.real = real;
            this.img = img;
        }
        ~Complex(){
            count--;
        
        }

        public int Real { get => real; set => real = value; }
        public int Img { get => img; set => img = value; }
        public static int Count { get => count; set => count = value; }

        public void print() {
            Console.WriteLine($"{real}:{img}J");
        
        
        }

    }
}
