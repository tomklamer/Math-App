using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class BracketStringCheck
	{
		public static void lookForOpeningToLeft(ref int currentPosition, string input)
		{
			int bracketOpeningCount = 0;
			int bracketClosingCount = 1;
			currentPosition--;
			for(int i = currentPosition; i >= 0; i--)
			{
				if(input[i] == Const.BRACKET_OPEN_SYMBOL)
				{
					bracketOpeningCount++;
				}else if(input[i] == Const.BRACKET_CLOSE_SYMBOL)
				{
					bracketClosingCount++;
				}

				if(bracketClosingCount == bracketOpeningCount)
				{
					currentPosition = i;
					break;
				}
			}
		}

		public static bool checkForSigns(string input)
		{
			foreach (char element in input)
			{
				if (CharCheck.isSign(element))
				{
					return true;
				}
			}
			return false;
		}


	}
}
