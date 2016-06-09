using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class FractionCalculatorFunctions
	{
		public static string calculateWithNonFractionA(string nonFractionA, string fractionB, string sign)
		{
			FractionClass fractionA = new FractionClass();
			fractionA.convertNumberToFraction(nonFractionA);
			string result = "0";

			result = performCases(fractionA.returnFractionAsString(), fractionB, sign);
			return result;
		}

		public static string calculateWithNonFractionB(string fractionA, string nonFractionB, string sign)
		{
			FractionClass fractionB = new FractionClass();
			fractionB.convertNumberToFraction(nonFractionB);
			string result = "0";

			result = performCases(fractionA, fractionB.returnFractionAsString(), sign);
			return result;

		}

		public static string calculateFractions(string fractionA, string fractionB, string sign)
		{
			string result = "0";

			result = performCases(fractionA, fractionB, sign);
			return result;
		}

		public static string performCases(string fractionAString, string fractionBString, string sign)
		{
			FractionClass fractionA = new FractionClass();
			FractionClass fractionB = new FractionClass();
			FractionClass solution = new FractionClass();

			fractionA.setFractionFromString(fractionAString);
			fractionB.setFractionFromString(fractionBString);

			switch (sign)
			{
				case Const.PLUS_SYMBOL_STRING:
					solution = FractionAddition.Add(fractionA, fractionB);
					break;
				case Const.MINUS_SYMBOL_STRING:
					solution = FractionSubstraction.Substract(fractionA, fractionB);
					break;
				case Const.MULTIPLY_SYMBOL_STRING:
					solution = FractionMultiplication.Multiply(fractionA, fractionB);
					break;
				case Const.DIVIDE_SYMBOL_STRING:
					solution = FractionDivision.Divide(fractionA, fractionB);
					break;
			}

			return solution.returnFractionAsString();
		}
	}
}
