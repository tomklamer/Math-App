using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class StringSpaceRemoval
	{
		public static void removeSpacesFromString(ref string input)
		{
			string result = null;
			if (input != null)
			{
				result = input.Replace(@" ", "");
				input = result;
				//return result;

			}
			//return null;
		}
	}
}
