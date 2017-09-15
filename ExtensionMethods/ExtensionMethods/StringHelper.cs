using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
	/*
	To convert ChangeFirstAndLastLetterCase() method to an extension method, make the following 2 changes
	1. Make StringHelper static class
	2. The type the method extends should be passed as a first parameter with this keyword preceeding it.
	*/
	public static class StringHelper
	{
		public static string ChangeFirstAndLastLetterCase(this string inputString)
		{
			if (inputString.Length > 0)
			{
				char[] charArray = inputString.ToCharArray();
				charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
				charArray[inputString.Length - 1] = char.IsUpper(charArray[inputString.Length - 1]) ? char.ToLower(charArray[inputString.Length - 1]) : char.ToUpper(charArray[inputString.Length - 1]);
				return new string(charArray);
			}

			return inputString;
		}

	}
}
