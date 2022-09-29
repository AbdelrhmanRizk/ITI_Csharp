using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    abstract class Shape
    {
         int dim1;
         int dim2;

        public Shape(int dim1, int dim2)
        {
            this.dim1 = dim1;
            this.dim2 = dim2;
        }

        public int Dim1 { get => dim1;set {
                if(dim1 > 0)
                    dim1 = value;
                else
                    Console.WriteLine("Invaild dim1 value");
            
            }
        }
        public int Dim2 { get => dim2; set {

                if (dim2 > 0)
                    dim2 = value;
                else
                    Console.WriteLine("Invaild dim2 value");

            }
        
        }

        public abstract float CalcArea();
        public abstract void Print();
    }
}
