using System;

// Program for Multicast Delegates

namespace Samples
{
	public delegate void Calculation1(double no1, double no2);

	public class DelegateTest1
	{		
		public static void Add(double no1, double no2)
		{
			Console.WriteLine("Addition of {0} & {1} is {2}",no1, no2, no1 + no2);
		}

		public static void Sub(double no1, double no2)
		{
			Console.WriteLine("Substraction of {0} & {1} is {2}",no1, no2, no1 - no2);
		}

		public static void Div(double no1, double no2)
		{
			Console.WriteLine("Division of {0} & {1} is {2}",no1, no2, no1 / no2);
		}

		public static void Mul(double no1, double no2)
		{
			Console.WriteLine("Multiplication of {0} & {1} is {2}",no1, no2, no1 * no2);
		}

        //Uncomment the following while executing this code.--------
        /*
		public static void Main()
		{
			double no1, no2;

			Calculation calc = new Calculation(Add);
			calc += new Calculation(Sub);
			calc += new Calculation(Div);
			calc += new Calculation(Mul);

			Console.WriteLine("Enter first value : ");
			no1 = double.Parse(Console.ReadLine().ToString());
			Console.WriteLine("Enter second value : ");
			no2 = double.Parse(Console.ReadLine().ToString());

			calc(no1,no2);
		}
**/			
	}
}