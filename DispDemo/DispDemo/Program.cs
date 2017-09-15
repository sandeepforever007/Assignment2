using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			IDispDemo dsp = new IDispDemo();
			Console.WriteLine("IDispemo object created");
			dsp.Greeting("Sandeep");
			dsp.Dispose();
			dsp = null;
			//dsp.Dispose();
			Console.WriteLine("After Dispose");
			Console.ReadKey();
		}
	}
}
