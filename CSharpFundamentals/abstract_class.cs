using System;

namespace Samples
{
	public abstract class Abstract
	{
		abstract public void DisplayMessage();
	}

	public class Derived : Abstract
	{
		public override void DisplayMessage()
		{
			Console.WriteLine("Hello World");
		}
	}

	public class TestApp
	{
        //Uncomment the following while executing this code.
        //public static void Main()
        //{
        //    Derived der = new Derived();

        //    der.DisplayMessage();
        //}
	}
}