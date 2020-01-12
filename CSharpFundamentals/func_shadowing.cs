using System;

namespace Samples
{
	// Virtual Base Class
	public class Base1
	{
		// Virtual Method
		public void Display()
		{
			Console.WriteLine("In Base Class");
		}
	}

	// Single Inheritance
	public class Derived2 : Base
	{
		public new void Display()
		{
			Console.WriteLine("In Derived Class");
		}
	}

	public class TestApp2
	{
        //Uncomment the following while executing this code.--------
        /*
		public static void Main()
		{
			Base bas = new Base();
			Derived der = new Derived();
			Base ba = new Derived();

			//Calling Base Class Method
			bas.Display();
			
			//Calling Derived Class Method
			der.Display();

			//Calling Derived Class Method
			ba.Display();
		}
         * */
	}
}