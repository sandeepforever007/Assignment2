using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispDemo
{
	class IDispDemo : IDisposable
	{
		private bool disposed = false;
		public void Greeting(string Name)
		{
			Console.WriteLine("Hello {0}", Name);
		}
		~IDispDemo()
		{
			Console.WriteLine("Inside Finalize");
			Dispose(false);
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);

		}

		protected void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					Console.WriteLine("Inside Disposable");
				}
				disposed = true;
			}

		}
	}
}
