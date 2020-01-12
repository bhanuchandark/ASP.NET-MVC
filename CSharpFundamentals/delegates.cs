using System;

// Program for Simple Delegates (Array of Delegates)

namespace Samples
{
	public delegate double Calculation(double no1, double no2);

	public class DelegateTest
	{		
		public static double Add(double no1, double no2)
		{
			return (no1 + no2);
		}

		public static double Sub(double no1, double no2)
		{
			return (no1 - no2);
		}

		public static double Div(double no1, double no2)
		{
			return (no1 / no2);
		}

		public static double Mul(double no1, double no2)
		{
			return (no1 * no2);
		}


		public static void Menu()
		{
			Console.WriteLine("1. Add Two Variables : ");
			Console.WriteLine("2. Sub Two Variables : ");
			Console.WriteLine("3. Div Two Variables : ");
			Console.WriteLine("4. Mul Two Variables : ");
			Console.WriteLine("5. Exit : ");
		}

        //Uncomment the following while executing this code.--------
        /*
		public static void Main()
		{
			int choice;
			double no1, no2;	
			Calculation[] calc = 
					    {
						new Calculation(Add),
						new Calculation(Sub),
						new Calculation(Div),
						new Calculation(Mul)
					    };

			Console.WriteLine("Enter first value : ");
			no1 = double.Parse(Console.ReadLine().ToString());
			Console.WriteLine("Enter second value : ");
			no2 = double.Parse(Console.ReadLine().ToString());

			do
			{
				Menu();

				Console.WriteLine("Enter Your Choice : ");
				choice = int.Parse(Console.ReadLine().ToString());
				
				switch(choice)
				{
					case 1 : 
						 Console.WriteLine(calc[0](no1,no2));
						 break;

					case 2 : Console.WriteLine(calc[1](no1,no2));
						 break;

					case 3 : Console.WriteLine(calc[2](no1,no2));
						 break;

					case 4 : Console.WriteLine(calc[3](no1,no2));
						 break;

					case 5 : return;
				}
				
			}while(true);			
		}
         * */
	}
}