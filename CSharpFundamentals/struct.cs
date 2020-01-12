using System;

namespace Samples
{
	public struct Student
	{
		private int id;
		public int ID
		{
			get
			{
				return id;
			}

			set
			{
                id = value;
			}
		}

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }


    }

	public class TestApp9
	{

		public static int Main()
		{
            Student std12 = new Student();
            std12.ID = 23;
            std12.FirstName = "Ravi";
            std12.LastName = "Tambade";
            std12.Address = "Pune";
            std12.Email = "ravi.tambade@transflower.in";

			Console.WriteLine("Studnets is : {0}  {1} {2} ",std12.ID, std12.FirstName, std12.LastName);
            Console.ReadLine();
            return 0;
		}
	}
}