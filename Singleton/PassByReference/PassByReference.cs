using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByReference
{
	public class User
	{

		public int UserID { get; set; }
		public string Name { get; set; }
		public void ChangeValue(int i, ref int j, out int k)
		{
			i = 10;
			j = 10;
			k = 10;
			Console.WriteLine("Within the funtion");
			Console.WriteLine(i);
			Console.WriteLine("ref" + j);
			Console.WriteLine("out" + k);

		}
		public void ChangeName(User user, ref User user1, out User user2)
		{
			user.UserID = 10;
			user.Name = "Sandeep";
			user1.UserID = 10;
			user1.Name = "Sandeep";
			user2 = new User() { UserID = 10, Name = "Sandeep" };
			Console.WriteLine(user.UserID);
			Console.WriteLine(user.Name);
			Console.WriteLine(user1.UserID);
			Console.WriteLine(user1.Name);
			Console.WriteLine(user2.UserID);
			Console.WriteLine(user2.Name);

			user = null;
			user1 = null;
			user2 = null;


		}
	}

	class PassByReference
	{
		static void Main(string[] args)
		{

			User objUser = new User()
			{
				UserID = 1,
				Name = "Rohith"
			};
			User objUser1 = new User()
			{
				UserID = 1,
				Name = "Rohith"
			};
			User objUser2 = new User();
			Console.WriteLine(objUser.UserID);
			Console.WriteLine(objUser.Name);
			Console.WriteLine(objUser1.UserID);
			Console.WriteLine(objUser1.Name);
			Console.WriteLine(objUser2.UserID);
			Console.WriteLine(objUser2.Name);
			int num1 = 5;
			int num2 = 5;
			int num3 = 5;

			Console.WriteLine("Before Calling the funtion");
			Console.WriteLine(num1);
			Console.WriteLine("ref" + num2);
			Console.WriteLine("out" + num2);
			objUser.ChangeValue(num1, ref num2, out num3);
			Console.WriteLine("After Calling the funtion");
			Console.WriteLine(num1);
			Console.WriteLine("ref" + num2);
			Console.WriteLine("out" + num2);



			objUser.ChangeName(objUser, ref objUser1, out objUser2);
			Console.WriteLine(objUser.UserID);
			Console.WriteLine(objUser.Name);
			try
			{
				Console.WriteLine(objUser1.UserID);
				Console.WriteLine(objUser1.Name);
			}
			catch (NullReferenceException ex)

			{

				Console.WriteLine("Ref" + " " + ex.Message);

			}

			try
			{

				Console.WriteLine(objUser2.UserID);
				Console.WriteLine(objUser2.Name);
			}
			catch (NullReferenceException ex)

			{
				Console.WriteLine("Out" + " " + ex.Message);

			}
			Console.ReadKey();
		}

	}

}
