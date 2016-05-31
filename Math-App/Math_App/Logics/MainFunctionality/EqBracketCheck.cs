using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class EqBracketCheck
	{
		public static bool hasBracketEquation(string input)
		{
			string tempBracket;
			int bracketOpeningIndex = 0;
			int bracketClosingIndex = 0;

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == Const.BRACKET_CLOSE_SYMBOL)
				{
					bracketOpeningIndex = i;
					bracketClosingIndex = i;
					BracketStringCheck.lookForOpeningToLeft(ref bracketOpeningIndex, input);
					tempBracket = StringGetter.getString(bracketOpeningIndex, bracketClosingIndex, input);
					if (FractionCheck.hasOnlyFraction(tempBracket) == false)
					{
						// has bracket
						return true;
					}
					else
					{
						//keep going
					}

				}
			}
			return false;
		}

	}
}
