using System;

namespace Samples
{
	// Virtual Base Class
	public class Base
	{
		// Virtual Method
		public virtual void Display()
		{
			Console.WriteLine("In Base Class");
		}
	}

	// Single Inheritance
	public class Derived1 : Base
	{
		public override void Display()
		{
			Console.WriteLine("In Derived Class");
		}
	}

	public class TestApp1
	{
        //Uncomment the following while executing this code.--------
        /*
		public static void Main()
		{
			Base bas = new Base();
			Derived1 der = new Derived();
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