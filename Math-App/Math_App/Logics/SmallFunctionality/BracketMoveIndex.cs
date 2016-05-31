using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class BracketMoveIndex
	{
		public static void skipNextBracketClosing(string input, ref int currentPosition)
		{
			for (int i = currentPosition; i < input.Length; i++)
			{
				if (input[i] == Const.BRACKET_CLOSE_SYMBOL)
				{
					currentPosition = i + 1;
					break;
				}
			}
		}

		public static void findPreviousBracketOpening(string input, ref int currentPosition)
		{
			int originalPosition = currentPosition;
			int numOfBracketOpenings = 0;
			int numOfBracketEndings = 0;

			if (currentPosition == 0)
			{
				currentPosition = Const.NOT_FOUND;
				return;
			}

			for (int i = currentPosition - 1; i >= 0; i--)
			{
				if (input[i] == Const.BRACKET_CLOSE_SYMBOL)
				{
					numOfBracketEndings++;
				}
				else if (input[i] == Const.BRACKET_OPEN_SYMBOL)
				{
					numOfBracketOpenings++;
				}

				if (numOfBracketOpenings == numOfBracketEndings && numOfBracketOpenings > 0)
				{
					currentPosition = i;
					return;
				}
				else if (i == 0 && currentPosition == originalPosition)
				{
					currentPosition = Const.NOT_FOUND;
				}

			}

		}
	}
}
