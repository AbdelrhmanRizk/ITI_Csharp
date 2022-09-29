using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Rectangle : Shape
    {
        public Rectangle(int dim1, int dim2) : base(dim1, dim2)
        {
            Dim1 = dim1;
            Dim2 = dim2;
        }

        public override float CalcArea() {

            return Dim1 * Dim2;
        
        }
        public override void Print() {
            if(Dim1 <= 0 || Dim2 <= 0)
                Console.WriteLine(); //Donot print any thing if input is invaild  
            else
                Console.WriteLine($"The area of the rectangle ={Dim1 * Dim2}");


        }
    }
}
