using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math_App.TempStorage;

namespace Math_App.StaticObjects
{
	public static class SolutionFinder
	{

		public static void findSolution(int current, List<Bracket> brackets, 
										MainEquation inputEquation, List<string> calculationList, 
										Bracket inputBracket)
		{
			char sign = '\0';
			float a = 0;
			float b = 0;
			float tempSolution = 0;
			for (int i = 0; i < calculationList.Count; i++) //multiplication first
			{
				int j = i;
				StringBuilder sb = new StringBuilder();
				sign = StringAnalyzer.getSign(calculationList.ElementAt(i));
				if (sign == 'x' || sign == '/')
				{
					a = Convert.ToSingle(Analyzer.getNumber(calculationList.ElementAt(i), current, brackets));
					b = Convert.ToSingle(Analyzer.getNumber(calculationList.ElementAt(i + 1), current, brackets));
					calculationList.RemoveAt(i);
					tempSolution = performCalculation(a, b, sign);
					EquationToShow tempEquation = new EquationToShow();
					tempEquation.setEquation(a, b, sign, tempSolution);
					inputEquation.equationsToShow.Add(tempEquation);

					sign = StringAnalyzer.getSign(calculationList.ElementAt(i));
					calculationList.RemoveAt(i);
					sb.Append(tempSolution.ToString("G"));
					sb.Append(sign);
					calculationList.Insert(i, sb.ToString());
					i--;
				}
				else
				{
					//empty sign
				}
			}

			for (int ii = 0; ii < calculationList.Count; ii++) //addition second
			{
				int j = ii;
				StringBuilder sbb = new StringBuilder();
				sign = StringAnalyzer.getSign(calculationList.ElementAt(ii));
				if (sign == '+' || sign == '-')
				{
					a = Convert.ToSingle(Analyzer.getNumber(calculationList.ElementAt(ii), current, brackets));
					b = Convert.ToSingle(Analyzer.getNumber(calculationList.ElementAt(ii + 1), current, brackets));
					calculationList.RemoveAt(ii);
					tempSolution = performCalculation(a, b, sign);

					EquationToShow tempEquation = new EquationToShow();
					tempEquation.setEquation(a, b, sign, tempSolution);
					inputEquation.equationsToShow.Add(tempEquation);

					sign = StringAnalyzer.getSign(calculationList.ElementAt(ii));
					calculationList.RemoveAt(ii);
					sbb.Append(tempSolution.ToString("G"));
					sbb.Append(sign);
					calculationList.Insert(ii, sbb.ToString());
					ii--;
				}
				else
				{
					//empty sign
				}
			}
			inputBracket.setSolution(tempSolution);

		}

		public static float performCalculation(float a, float b, char sign)
		{
			float solution = 0;
			switch (sign)
			{
				case 'x':
					{
						solution = a * b;
						break;
					}
				case '/':
					{
						solution = a / b;
						break;
					}
				case '+':
					{
						solution = a + b;
						break;
					}
				case '-':
					{
						solution = a - b;
						break;
					}
			}
			return solution;
		}



	}
}
