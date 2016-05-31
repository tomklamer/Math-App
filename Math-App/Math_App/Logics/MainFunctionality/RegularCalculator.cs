using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class RegularCalculator
	{
		public static string calculate(string a, string b, string sign)
		{
			float result = 0;
			float floatA = Convert.ToSingle(a);
			float floatB = Convert.ToSingle(b);

			switch (sign)
			{
				case Const.MULTIPLY_SYMBOL_STRING:
					result = floatA * floatB;
					break;
				case Const.DIVIDE_SYMBOL_STRING:
					result = floatA / floatB;
					break;
				case Const.PLUS_SYMBOL_STRING:
					result = floatA + floatB;
					break;
				case Const.MINUS_SYMBOL_STRING:
					result = floatA - floatB;
					break;

			}

			return result.ToString();
		}
	}
}
