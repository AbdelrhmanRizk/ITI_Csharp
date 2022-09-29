using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesTask
{
    class Complex
    {
        int real;
        int img;

        public Complex(int _real, int _img)
        {
            real = _real;
            img = _img;
        }

        //getter
        public  int GetReal(){
            return real;
        }
        public int GetImg() {
            return img;
        
        }


        //setter
        public void SetReal(int _real)
        {
            real = _real;
        }
        public void SetImg(int _img)
        {
            img = _img;

        }




        public void print()
        {
            if (img > 0)
                Console.WriteLine($"{real}+{img}t");
            else if (img < 0)
                Console.WriteLine($"{real}{img}t");
            else
                Console.WriteLine(real);

            Console.ReadKey();
        }



    }
}
