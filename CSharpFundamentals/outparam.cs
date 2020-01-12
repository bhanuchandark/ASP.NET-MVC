using System;

namespace Samples
{
	public class OutParam
	{
		public void CallMe()
		{
			int a,b;

			Fill(out a);

			//Console.WriteLine(b,a);
		}

		public void Fill(out int a)
		{
			a = 10;
		}

        //Uncomment the following while executing this code.--------
        /*
		public static void Main()
		{		
			OutParam outPar = new OutParam();

			outPar.CallMe();
		}
         * */
	}
}