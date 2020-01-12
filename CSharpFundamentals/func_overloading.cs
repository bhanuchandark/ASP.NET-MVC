using System;

namespace Samples
{
	public class Overloading
	{
		public void Add(int val1, int val2)
		{
			Console.WriteLine(val1 + val2);
		}

		public void Add(int val1, int val2, int val3)
		{
			Console.WriteLine(val1 + val2 + val3);
		}

		public void Add(float val1, float val2)
		{
			Console.WriteLine(val1 + val2);
		}

		public void Add(int val1, float val2)
		{
			Console.WriteLine(val1 + val2);
		}

		public void Add(float val1, int val2)
		{
			Console.WriteLine(val1 + val2);
		}

        //Uncomment the following while executing this code.--------
        /*
		public static void Main()
		{
			Overloading over = new Overloading();
			
			over.Add(10,20);
			over.Add(10,20,30);						
			over.Add(10.123f,20.123f);
			over.Add(10,20.123f);
			over.Add(10.123f,20);
		}
         * */
	}
}