using System;

namespace Samples
{
	public class StaticTest
	{
		private static int _count = 1;
		private int _objNo;

		public StaticTest()
		{
			_objNo = _count++;
		}

		public int GetCount()
		{
			return _objNo;
		}

		~StaticTest()
		{
			Console.WriteLine(--_count);
		}
	}

	public class TestApp8
	{
        /*
		public static void Main()
		{
			StaticTest t1 = new StaticTest();
			StaticTest t2 = new StaticTest();
			StaticTest t3 = new StaticTest();
	
			Console.WriteLine("Obect No : " + t1.GetCount());
			Console.WriteLine("Obect No : " + t2.GetCount());
			Console.WriteLine("Obect No : " + t3.GetCount());
		}
         * */
	}
}