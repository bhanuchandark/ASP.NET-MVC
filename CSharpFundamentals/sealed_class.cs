using System;

namespace Samples
{
	public sealed class Base4
	{
		public void DisplayMessage()
		{
			Console.WriteLine("In Sealed Base Class");
		}
	}

	
	/*
	//Cannot Inherit Sealed Classes
	public class Derived : Base
	{
		public new void DisplayMessage()
		{
			Console.WriteLine("In Derived Class");			
		}
	}
	*/

	public class TestApp6
	{
        /*
		public static void Main()
		{
			Base ba = new Base();
			ba.DisplayMessage();

			//Derived der = new Derived();
			//der.DisplayMessage();
		}
         * */
	}
}