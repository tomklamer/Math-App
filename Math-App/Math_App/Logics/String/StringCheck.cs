using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Logics
{
    public static class StringCheck
    {
		public static bool isDigit(string input)
		{
			foreach(char element in input)
			{
				switch (element)
				{
					case Const.BRACKET_OPEN_SYMBOL:
					case Const.BRACKET_CLOSE_SYMBOL:
					case Const.DIVIDE_SYMBOL:
					case Const.PLUS_SYMBOL:
					case Const.MINUS_SYMBOL:
					case Const.MULTIPLY_SYMBOL:
					case Const.FRACTION_SYMBOL:
						return false;
					default:
						break;
				}
			}

			// nothing found
			return true;
		}
    }
}
