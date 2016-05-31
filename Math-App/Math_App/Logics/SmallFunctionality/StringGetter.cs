using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class StringGetter
	{
		public static string getString(int beginIndex, int endIndex, string input)
		{
			StringBuilder sb = new StringBuilder();
			for(int i = beginIndex; i <= endIndex; i++)
			{
				sb.Append(input[i]);
			}
			return sb.ToString();
		}
	}
}
