using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class FractionCheck
	{
		public static bool hasOnlyFraction(string input)
		{
			bool hasBracketOpen = false;
			bool hasBracketClose = false;
			bool hasFractionSymbol = false;

			foreach (char tempChar in input)
			{
				switch (tempChar)
				{
					case Const.BRACKET_OPEN_SYMBOL:
						hasBracketOpen = true;
						break;

					case Const.BRACKET_CLOSE_SYMBOL:
						hasBracketClose = true;
						break;
					case Const.FRACTION_SYMBOL:
						hasFractionSymbol = true;
						break;

					case '+':
					case '-':
					case ':':
					case '*':
						return false;

				}
			}

			if(hasBracketOpen && hasBracketClose && hasFractionSymbol)
			{
				return true;
			}
			return false;
		}
	}
}
