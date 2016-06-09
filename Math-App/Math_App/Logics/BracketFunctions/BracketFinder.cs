using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
    public static class BracketFinder
    {

		public static string getTopBracket(string input)
		{
			int bracketOpeningIndex = 0;
			int bracketClosingIndex = 0;
			string tempBracket;

			for(int i = 0; i < input.Length; i++)
			{
				if(input[i] == Const.BRACKET_CLOSE_SYMBOL)
				{
					bracketOpeningIndex = i;
					bracketClosingIndex = i;

					BracketStringCheck.lookForOpeningToLeft(ref bracketOpeningIndex, input);
					tempBracket = StringGetter.getString(bracketOpeningIndex, bracketClosingIndex, input);

					if (FractionCheck.hasOnlyFraction(tempBracket) == false)
					{
						return tempBracket;
					}else
					{
						//keep going
					}
				}
			}
			// Something went wrong

			return null;
		}


		public static void clearBrackets(ref string input)
		{
			List<int> usableBracketIndex = new List<int>();
			List<int> foundBracketIndex = new List<int>();

			List<char> tempString = new List<char>();

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == Const.BRACKET_OPEN_SYMBOL)
				{
					tempString.Add(input[i]);
				}
				else if (input[i] == Const.BRACKET_CLOSE_SYMBOL)
				{
					tempString.Add(input[i]);
				}
				else if (CharCheck.isSign(input[i]) || input[i] == Const.FRACTION_SYMBOL)
				{
					tempString.Add('s');
				}
				else if (CharCheck.isPartOfDigit(input[i].ToString()))
				{
					tempString.Add('d');
				}
			}

			int digitCount = 0;
			int signCount = 0;


			for (int i = 0; i < tempString.Count(); i++)
			{
				if (tempString[i] == Const.BRACKET_CLOSE_SYMBOL)
				{
					for (int j = i; j >= 0; j--)
					{
						if (tempString[j] == 's')
						{
							signCount++;
						}
						if (tempString[j] == 'd')
						{
							digitCount++;
						}

						if (tempString[j] == Const.BRACKET_OPEN_SYMBOL)
						{
							if (signCount != 0)
							{
								for (int k = j; k <= i; k++)
								{
									if (tempString[k] != 'r')
									{
										tempString[k] = 'u';
									}
									else
									{
										tempString[k] = 'r';
									}
								}
								tempString[i] = 'u';
								tempString[j] = 'u';
								if (i == input.Length - 1 && j == 0)
								{
									tempString[i] = 'r';
									tempString[j] = 'r';
								}
							}
							else
							{
								tempString[i] = 'r';
								tempString[j] = 'r';
							}
							break;
						}
					}
					signCount = 0;
					digitCount = 0;
				}
			}

			StringBuilder sb = new StringBuilder();
			sb.Append(input);

			for (int i = sb.Length - 1; i >= 0; i--)
			{
				if (tempString[i] == 'r')
				{
					tempString.RemoveAt(i);
					sb.Remove(i, 1);
				}
			}

			input = sb.ToString();
		}

		public static bool isNotBracket(char input)
		{
			if(input == Const.BRACKET_CLOSE_SYMBOL ||
				input == Const.BRACKET_OPEN_SYMBOL)
			{
				return false;
			}else
			{
				return true;
			}
		}

		public static bool makesBracketUsable(char input)
		{
			if(input != Const.BRACKET_CLOSE_SYMBOL ||
				input != Const.BRACKET_OPEN_SYMBOL ||
				input != Const.SPACE ||
				CharCheck.isSign(input) == false)
			{
				return true;
			}
			else
			{
				return false;
			}
		}



		

    }
}
