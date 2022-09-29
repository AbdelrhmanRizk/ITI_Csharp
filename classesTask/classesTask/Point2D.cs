using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesTask
{
    class Point2D
    {
        double x_axis;
        double y_axis;

        public Point2D(double x_axis, double y_axis)
        {
            this.x_axis = x_axis;
            this.y_axis = y_axis;
        }

        public double X_axis { get => x_axis; set => x_axis = value; }
        public double Y_axis { get => y_axis; set => y_axis = value; }

        public void print()
        {
            Console.WriteLine($"x={x_axis} , y:{y_axis}");
        }
    }
}
