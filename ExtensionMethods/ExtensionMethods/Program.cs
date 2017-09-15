using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = "sandeep";
			string result = input.ChangeFirstAndLastLetterCase();
			Console.WriteLine(result);
			Console.ReadKey();
		}
	}
}
