using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Struct_Enum_Properties
{
    struct Point //No overhead data / value type
    {
        int x;
        int y;


        // public Point() { } erro because struct constractor must be fully assigned

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }



        //properties
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public void Print()
        {
            Console.WriteLine($"{x}:{y}");

        }
    }
}
