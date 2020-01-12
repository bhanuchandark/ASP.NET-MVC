using System;

namespace Samples
{
	public class Base3
	{
		private readonly int val;

		// Default Constructor
		public Base3()
		{
			val = 5;
		}

		// Overloaded Parameterized Constructor
		public Base3(int val)
		{
			this.val = val;
		}

		public void Display()
		{
			Console.WriteLine(val);
		}
	}

	public class ReadonlyTest2 : Base3
	{
		public ReadonlyTest2()
		{
			
		}

		public ReadonlyTest2(int val) : base(val)
		{
			
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