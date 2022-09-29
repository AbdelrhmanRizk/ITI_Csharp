using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesTask
{
    class Car
    {
        int speed;
        string color;
        string brand;

        public Car(int speed, string color, string brand)
        {
            this.speed = speed;
            this.color = color;
            this.brand = brand;
        }

        public int Speed { get => speed; set => speed = value; }
        public string Color { get => color; set => color = value; }
        public string Brand { get => brand; set => brand = value; }

        public void brake()
        {
            speed = 0;
        }

        public void accelerate(int rateOfAcceleration,int speed)
        {
            Console.WriteLine($"The new speed ={rateOfAcceleration+speed}");
        }







    }
}
