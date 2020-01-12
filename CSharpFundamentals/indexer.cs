using System;

namespace Samples
{
	public class Indexer
	{
		private int [] arry = new int[5];

		public int this [int index]
		{
			get
			{
				// Check the index limits.
         			if (index < 0 || index >= 100)
            				return 0;
         			else
					return arry[index];
			}

			set
			{
				if (!(index < 0 || index >= 5))
					arry[index] = value;
			}
		}

        //Uncomment the following while executing this code.--------
        /*
		public static void Main()
		{
			Indexer ind = new Indexer();
			
			ind[0] = 10;
			ind[5] = 20;
			
			for(int i = 0; i < 5; i++)
				Console.WriteLine(ind[i]);
		}
         * */
	}	
}