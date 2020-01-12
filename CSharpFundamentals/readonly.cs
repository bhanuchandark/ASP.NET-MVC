using System;

namespace Samples
{
	public class ReadonlyTest
	{
		private readonly int val;
		private const int cons = 5;

		// Default Constructor	
		public ReadonlyTest()
		{
		
		}

		// Overloaded Parameterized Constructor
		public ReadonlyTest(int val)
		{
			this.val = val;
		}

		public void Display()
		{
			Console.WriteLine("Constant's Value : {0}",cons);
			Console.WriteLine("Readonly's Value : {0}",val);
		}

        //Uncomment the following while executing this code.--------
        /*
		public static void Main()
		{
			ReadonlyTest test = new ReadonlyTest(10);

			test.Display();
		}
         * */
	}
}