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

		public static bool isPartOfDigit(string input)
		{
			switch (input)
			{
				case "0":
				case "1":
				case "2":
				case "3":
				case "4":
				case "5":
				case "6":
				case "7":
				case "8":
				case "9":
					return true;
					break;
				case ",":
				case ".":
					return true;
				default:
					return false;
			}
		}

		public static bool isFloat(string input)
		{
			float tempFloat;
			return float.TryParse(input, out tempFloat);
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
