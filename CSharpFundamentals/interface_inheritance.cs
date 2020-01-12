using System;

namespace Samples
{
	//Interface Declaration
	public interface IMessageProvider
	{
		// Method Scope is Bydefault public
		void DisplayMessage();
	}

	// Single Interface inheritance
	public class Derived3 : IMessageProvider
	{
		public void DisplayMessage()
		{
			Console.WriteLine("Interface Inheritance");
		}
	}

	public class TestApp3
	{
        //Uncomment the following while executing this code.--------
        /*
		public static void Main()
		{
			Derived der = new Derived();
			
			der.DisplayMessage();
		}
         * */
	}
}