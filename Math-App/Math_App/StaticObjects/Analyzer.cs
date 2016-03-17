using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math_App.TempStorage;

namespace Math_App.StaticObjects
{
	public static class Analyzer
	{

		public static void getBrackets(string equation, List<Bracket> brackets)
		{
			List<int> usedBrackets = new List<int>();
			//mainEquation fk = new mainEquation();

			for (int openCursor = 0; openCursor < equation.Length; openCursor++) //I increase values in used Bracket List by 1 so that when I look for 0, I actually look for 1. Zero here also means false.
			{
				if (equation[openCursor] == '(' && usedBrackets.Find(x => x == (openCursor + 1)) == 0)
				{
					for (int closeCursor = openCursor; closeCursor < equation.Length; closeCursor++)
					{
						if (equation[closeCursor] == ')' && usedBrackets.Find(x => x == (closeCursor + 1)) == 0)
						{
							usedBrackets.Add(closeCursor + 1);
							for (int openCursorBis = closeCursor; openCursorBis >= 0; openCursorBis--)
							{
								if (equation[openCursorBis] == '(' && usedBrackets.Find(x => x == (openCursorBis + 1)) == 0)
								{
									usedBrackets.Add(openCursorBis + 1);
									Bracket tempBracket = new Bracket();
									tempBracket.setString(getEquationFragment((openCursorBis + 1), (closeCursor - 1), equation));
									brackets.Add(tempBracket);
									break;
								}
							}

						}
					}
				}
			}
			Bracket tempBracketBis = new Bracket();
			tempBracketBis.setString(equation);
			brackets.Add(tempBracketBis);
		}


		public static string getEquationFragment(int begin, int end, string equation)
		{
			StringBuilder sb = new StringBuilder();

			for (int i = begin; i <= end; i++)
			{
				sb.Append(equation[i]);
			}
			string tempString = sb.ToString();
			return tempString;
		}

		public static void buildCalculationList(MainEquation equation)
		{
			int index = 0;
			foreach(Bracket bracket in equation.brackets)
			{
				index = 0;
				StringBuilder sb = new StringBuilder();
				while(index + 1 < bracket.getString().Length)
				{
					sb.Append(getNumberOrBracket(bracket.getString(), ref index));
					sb.Append(getSign(bracket.getString(), ref index));
					bracket.addToCalculationList(sb.ToString());
					sb.Clear();
				}
				//Console.WriteLine("Build Calculation List: ");
			}
		}

		public static string getNumberOrBracket(string equation, ref int startNum)
		{
			StringBuilder sb = new StringBuilder();
			int numBracketOpen = 0;
			int numBracketClose = 0;
			for(int i = startNum; i < equation.Length; i++)
			{
				
				if (Char.IsNumber(equation[i])) //number found
				{
					while (Char.IsNumber(equation[i]))
					{
						sb.Append(equation[i]);
						i++;
						if(i >= equation.Length)
						{
							break;
						}
					}
					startNum = i + 1;
					break;
				}else if (equation[i] == '(')
				{
					sb.Append(equation[i]);
					numBracketOpen++;
					do
					{
						i++;
						sb.Append(equation[i]);
						if(equation[i] == '(')
						{
							numBracketOpen++;
						}else if(equation[i] == ')')
						{
							numBracketClose++;
						}
					} while (numBracketOpen != numBracketClose);
					startNum = i + 1; 
					break;
				}
				startNum = i + 1;
			}
			return sb.ToString();
		}

		public static char getSign(string equation, ref int startNum)
		{
			for(int i = startNum; i < equation.Length; i++)
			{
				if (isSign(equation[i]))
				{
					return equation[i];
				}
			}
			return '\0';
		}

		public static bool isSign(char toCheck)
		{
			if (toCheck == '+' ||
				toCheck == '-' ||
				toCheck == 'x' ||
				toCheck == '/')
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public static string getNumber(string stringToCheck, int curBracket, List<Bracket> brackets)
		{
			StringBuilder sb = new StringBuilder();
			bool containsBracket = false;
			for (int i = 0; i < stringToCheck.Length; i++)
			{
				int bracketCount = brackets[curBracket].getBracketCount() - 1;

				if (isSign(stringToCheck[i]) == false)
				{
					if (stringToCheck[i] == '(')
					{
						containsBracket = true;
					}
					sb.Append(stringToCheck[i]);
				}
				else
				{
					if (containsBracket == true)
					{
						if(brackets[curBracket].getBracketCount() > 1)
						{
							for(int j = curBracket; j >= 0; j--)
							{
								//Console.WriteLine("Checking {0}", brackets[j].getString());
								if (brackets[j].getContainsBracket() == false ) {
									bracketCount--;
									//Console.WriteLine("BracketCount: {0}", brackets[j].getBracketCount());
									if(bracketCount == 0)
									{
										//Console.WriteLine("The bracket found is: {0}", brackets[j].getString());
										//Console.WriteLine("Got solution: {0}", brackets[j].getSolution());
										brackets[curBracket].setBracketCount(brackets[curBracket].getBracketCount() - 1);
										return brackets[j - 1].getSolution().ToString("G");
									}
								}
							}
						}
						else
						{

						}
						return brackets[curBracket - 1].getSolution().ToString("G");
					}
					break;
				}
			}
			return sb.ToString();

		}
		


	}
}
