using System;

namespace Samples
{
	public class SingleTon
	{
		private static SingleTon _ref = null;
		private int _val;

		private SingleTon()
		{
			_val = 10;
		}

		public int Val
		{
			get
			{
				return _val;
			}

			set
			{
				if(value < 0)
					throw new Exception("Value Cannot be zero");

				_val = value;
			}
		}

		public static SingleTon GetObject()
		{
			if(_ref == null)
				_ref = new SingleTon();

			return _ref; 
		}
	}

	public class TestApp7
	{
        //Uncomment the following while executing this code.--------
        /*
		public static void Main()
		{
			SingleTon t1,t2;
			string s1;
			float f1;
		
			try
			{
				t1 = SingleTon.GetObject();
				t2 = SingleTon.GetObject();

				t1.Val = 10;

				Console.WriteLine("A : {0}",t1.Val);
				Console.WriteLine("A : {0}",t2.Val);

				try
				{
					s1 = t1.Val.ToString();
					f1 = (float) t1.Val;

					t1.Val = int.Parse(s1);
					t1.Val = Convert.ToInt32(s1);
				}
				catch(Exception ex)
				{
					Console.WriteLine("General Exception Block : " + ex.Message);
				}		
			}			
			catch(Exception ex)
			{
				Console.WriteLine("General Exception Block : " + ex.Message);
			}
			finally
			{
				t1 = null;
				Console.WriteLine("It always get called");
			}
		}
         * */
	}
}