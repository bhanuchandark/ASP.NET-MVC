using System;
using System.Collections;

namespace Samples
{
	public class HashTableTest
	{
        //Uncomment the following while executing this code.--------
        /*
		public static void Main(string[] args)
		{
			Hashtable hash = new Hashtable();
			int key;
		
			for(int i = 0; i < 10 ; i++)
			{
				if(hash.ContainsKey(i) == false)
					hash.Add(i,(i+1));
			}
		

			Console.WriteLine("Enter the value (1-10) that you want to find : ");

			key = int.Parse(Console.ReadLine().ToString());
			
			Console.WriteLine(hash[key].ToString());		
		}
         * */
	}
}

// Compilation Process:
// csc hashtable.cs
// hashtable