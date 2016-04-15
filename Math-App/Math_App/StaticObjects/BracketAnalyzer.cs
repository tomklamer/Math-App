using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math_App.TempStorage;

namespace Math_App.StaticObjects
{
	public static class BracketAnalyzer
	{

		public static void checkForBrackets(Bracket inputBracket)
		{
			bool bracketOpenFound = false;
			bool bracketCloseFound = false;
			for (int i = 0; i < inputBracket.getString().Length; i++)
			{
				if (inputBracket.getString()[i] == '(')
				{
					//Console.WriteLine("Found Open!");
					bracketOpenFound = true;
				}
				else if (inputBracket.getString()[i] == ')')
				{
					//Console.WriteLine("Found Close!");
					bracketCloseFound = true;
				}
				if (bracketOpenFound && bracketCloseFound)
				{

					//Console.WriteLine("Found Open!");
					inputBracket.setContainsBracket(true);
					break;
				}
			}

		}

		public static char getSign(string toCheck)
		{
			int openBracket = 0;
			int closeBracket = 0;
			for (int i = 0; i < toCheck.Length; i++)
			{
				if (toCheck[i] == '(')
				{
					openBracket++;
				}
				else if (toCheck[i] == ')')
				{
					closeBracket++;
				}
				if (openBracket == closeBracket)
				{
					if (toCheck[i] == '+' ||
					toCheck[i] == '-' ||
					toCheck[i] == 'x' ||
					toCheck[i] == '÷')
					{
						return toCheck[i];
					}
				}
			}
			return '\0';
		}

		public static void countBrackets(Bracket inputBracket)
		{
			int bracketCount = 0;
			int openCount = 0;
			int closeCount = 0;
			for (int i = 0; i < inputBracket.getString().Length; i++)
			{
				if (inputBracket.getString()[i] == '(' || inputBracket.getString()[i] == ')')
				{
					if (inputBracket.getString()[i] == '(')
					{
						openCount++;
					}
					else if (inputBracket.getString()[i] == ')')
					{
						closeCount++;
					}
					if (openCount == closeCount && openCount > 0)
					{
						bracketCount++;
					}
				}
				if (StringAnalyzer.isSign(inputBracket.getString()[i]) && openCount == closeCount)
				{
					inputBracket.setSignCount(inputBracket.getSignCount() + 1);
				}
			}
			inputBracket.setBracketCount(bracketCount);
		}

	}
}
