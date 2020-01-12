using System;
using System.Collections;

namespace Samples
{
	public class ArrayListTest
	{	
		private int _val;

		public int Val
		{
			get
			{
				return _val;
			}
			set
			{
				_val = value;
			}
		}

        //Uncomment the following while executing this code.--------
        /*
		public static void Main(string[] args)
		{
			ArrayList list = new ArrayList();
			ArrayListTest arrList = null;

			for(int i = 0 ; i < 5 ; i++)
        		{
				arrList = new ArrayListTest();

				Console.Write("Enter a Number : ");

				arrList.Val = int.Parse(Console.ReadLine().ToString());

				list.Add(arrList);
			}

			for(int i = 0 ; i < 5 ; i++)
        		{
				arrList = (ArrayListTest) list[i];
				Console.WriteLine(arrList.Val);
			}

        		foreach(object obj in list)
        		{
				arrList = (ArrayListTest) obj;
				Console.WriteLine(arrList.Val);
			}			
		}*/
	}
}

// Compilation Process:
// csc arraylist.cs
// arraylist