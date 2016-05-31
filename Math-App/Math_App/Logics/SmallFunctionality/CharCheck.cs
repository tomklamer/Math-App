using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{ 
	public static class CharCheck
	{
		public static bool isDigit(char input)
		{
			int tempInt;
			return int.TryParse(input.ToString(), out tempInt);
		}

		public static bool isDigit(string input)
		{
			int tempInt;
			return int.TryParse(input, out tempInt);
		}

		public static bool isSign(char input)
		{
			switch (input)
			{
				case Const.PLUS_SYMBOL: return true;
				case Const.MINUS_SYMBOL: return true;
				case Const.MULTIPLY_SYMBOL: return true;
				case Const.DIVIDE_SYMBOL: return true;
			
				default: return false;
			}
		}

	}
}
