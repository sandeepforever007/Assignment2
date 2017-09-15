using System;

namespace Singleton
{
	class SingletonPattern
	{
		private static SingletonPattern instance = null;
		public string Name { get; set; }
		private string IP { get; set; }
		private SingletonPattern()
		{
			Console.WriteLine("Singleton Intance");

			Name = "Server1";
			IP = "192.168.1.23";
		}
		private static object syncLock = new object();

		public static SingletonPattern Instance
		{
			get
			{
				lock (syncLock)
				{
					if (SingletonPattern.instance == null)
						SingletonPattern.instance = new SingletonPattern();

					return SingletonPattern.instance;
				}
			}
		}

		public void Show()
		{
			Console.WriteLine("Server Information is : Name={0} & IP={1}", Name, IP);
		}

	}


	class Program
	{
		static void Main(string[] args)
		{




			SingletonPattern.Instance.Show();

			SingletonPattern s1 = SingletonPattern.Instance;
			s1.Name = "Sandeep";
			SingletonPattern s2 = SingletonPattern.Instance;
			s2.Name = "Rohith";

			Console.WriteLine(s1.Name);
			Console.WriteLine(s2.Name);
			Console.WriteLine("Only one instance is active at a given time");
			Console.ReadKey();
		}
	}

}
