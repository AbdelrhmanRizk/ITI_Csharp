using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Complex c = new Complex(1,-10);
            c.print();
            //TaskArray();
            //TaskFactorial();

        }

        public static void TaskArray() {

            Console.WriteLine("please enter first num of student");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter second num of subject");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();


            //get degree from user
            int[,] arr = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();


            //Calculate sum
            int[] sum = new int[a];
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    sum[i] += arr[i, j];


            //OUTPUT
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write($"{ arr[i, j]} ,");
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sum[i]);
                Console.WriteLine();
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void TaskFactorial() {

            int fact = 1;
            Console.WriteLine("please enter the number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++) {
                fact *= i;
            }
            Console.WriteLine($"factorial of {num} = {fact}");
            Console.ReadKey();
        }
    }
}
