using System;

namespace Samples
{
	public class RefParam
	{
		public void FillArray(ref int[] arr)
		{
			// Create the array on demand:
      			if (arr == null)
         			arr = new int[5];

      			// Otherwise fill the array:
      			arr[0] = 100;
			arr[3] = 400;
		}

        //Uncomment the following while executing this code.--------
        /*
		public static void Main()
		{
			int[] arr = {1,2,3,4,5};
			RefParam refPar = new RefParam();

			// Pass the array using ref:		
			refPar.FillArray(ref arr);

			// Display the updated array:
      			Console.WriteLine("Array elements are:");
      			for (int i = 0; i < arr.Length; i++) 
         			Console.WriteLine(arr[i]);
		}
         **/
	}
         
}