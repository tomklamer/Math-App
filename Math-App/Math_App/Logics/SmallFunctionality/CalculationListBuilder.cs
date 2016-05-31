using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class CalculationListBuilder
	{
		public static void buildCalculationLists(string input, ref List<string> numberList, ref List<string> signList)
		{
			StringBuilder sb = new StringBuilder();
			string currentNumber;
			string currentSign;

			int bracketOpeningIndex = 0;
			int bracketClosingIndex = 0;

			int amountOfBracketOpenings = 0;
			int amountOfBracketClosings = 0;

			int fractionStartIndex = 0;
			int fractionEndIndex = 0;

			StringSpaceRemoval.removeSpacesFromString(ref input);

			// look for numbers

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == Const.BRACKET_OPEN_SYMBOL)
				{
					bracketOpeningIndex = i;
					while (amountOfBracketClosings == amountOfBracketOpenings && amountOfBracketOpenings > 0)
					{
						i++;
						if (input[i] == Const.BRACKET_CLOSE_SYMBOL)
						{
							amountOfBracketClosings++;
						}
						else if (input[i] == Const.BRACKET_OPEN_SYMBOL)
						{
							amountOfBracketOpenings++;
						}
					}



					if (FractionCheck.hasOnlyFraction(
						input.Substring(bracketOpeningIndex, i - bracketOpeningIndex + 1)
						) == true)
					{
						numberList.Add(input.Substring(bracketOpeningIndex, i - bracketOpeningIndex + 1));
					}
					else
					{
						i = bracketOpeningIndex;
					}
				}
				else if (CharCheck.isDigit(input[i]))
				{
					while (CharCheck.isDigit(input[i]))
					{
						sb.Append(input[i].ToString());
						if (i + 1 >= input.Length)
						{
							break;
						}
						else
						{
							i++;
						}
					}


					numberList.Add(sb.ToString());
					sb.Clear();
				}

				if (input[i] == Const.FRACTION_SYMBOL)
				{
					// remove last element
					numberList.RemoveAt(numberList.Count() - 1);

					fractionStartIndex = i;
					fractionEndIndex = i;

					EquationSolver.findFractionBeginning(ref fractionStartIndex, input);
					EquationSolver.omitFraction(ref fractionEndIndex, input);

					numberList.Add(input.Substring(fractionStartIndex, fractionEndIndex - fractionStartIndex + 1));
					i = fractionEndIndex;

				}
			}

			lookForSigns(ref signList, input);

		}

		public static void lookForSigns(ref List<string> signList, string input)
		{
			for (int i = 0; i < input.Length; i++)
			{
				if (CharCheck.isSign(input[i]))
				{
					signList.Add(input[i].ToString());
				}
			}

		}

	}
}
