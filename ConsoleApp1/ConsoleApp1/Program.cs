using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			task1();
			task2();
			task3();
			task4();
			task5();

		}
		static void task1() {

			Console.WriteLine("please enter a number");
			int num = int.Parse(Console.ReadLine());
			if (num % 2 == 0)
				Console.WriteLine("your num is even");
			else if (num % 2 == 1)
				Console.WriteLine("your num is odd");
			else
				Console.WriteLine("you enter zero");
			Console.ReadKey();
		}

		static void task2()
        {
			Console.WriteLine("please your degree");
			int degree = int.Parse(Console.ReadLine());
			if (degree < 50)
				Console.WriteLine("Fail");
			else if (degree >= 50 && degree < 65 )
				Console.WriteLine("pass");
			else if (degree >= 65 && degree < 80)
				Console.WriteLine("good");
			else if (degree >= 80 && degree < 90)
				Console.WriteLine("very good");
			else if (degree >= 90 && degree <= 100 )
				Console.WriteLine("exellent");
			else
				Console.WriteLine("invailed degree");
			Console.ReadKey();

		}
		static void task3()
		{

			Console.WriteLine("please enter your first num");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("please enter your second num");
			int num2 = int.Parse(Console.ReadLine());
			Console.WriteLine("please enter your opertion");
			char oper = char.Parse(Console.ReadLine());

			if (oper == '+')
				Console.WriteLine(num1 + num2);
			else if (oper == '-')
				Console.WriteLine(num1 - num2);
			else if (oper == '*')
				Console.WriteLine(num1 * num2);
			else if (oper == '/')
				Console.WriteLine(num1 / num2);
			else
				Console.WriteLine("something wrong");
			Console.ReadKey();


		}
		static void task4()
		{
			for (int i = 1; i <= 100; i++)
				Console.Write($"{i}-");
			Console.ReadKey();
		}

		static void task5()
			
		{
			int sum = 0;
			for (int i = 1; i <= 100; i++)
				sum = sum + i;
			Console.Write(sum);
			Console.ReadKey();
		}



	}

	}
