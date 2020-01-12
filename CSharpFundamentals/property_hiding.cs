using System;

namespace Samples
{
	public class Base2
	{
		private string _name;
		
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}
	}

	public class Derived4 : Base
	{
		private string _name;
		
		public new string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}		
	}

	public class TestApp5
	{
        //Uncomment the following while executing this code.--------
        /*
		public static void Main()
		{
			Base ba = new Derived();

			ba.Name = "Sachin";
			Console.WriteLine(ba.Name);
		}
         * */
	}
}