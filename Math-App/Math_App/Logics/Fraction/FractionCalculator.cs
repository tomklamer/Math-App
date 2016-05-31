using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class FractionCalculator
	{
		public static string calculate(string fractionA, string fractionB, string sign)
		{
			string result = "0";
			if (FractionCheck.hasOnlyFraction(fractionA) == false)
			{
				result = FractionCalculatorFunctions.calculateWithNonFractionA(fractionA, fractionB, sign);
			}else if(FractionCheck.hasOnlyFraction(fractionB) == false)
			{
				result = FractionCalculatorFunctions.calculateWithNonFractionB(fractionA, fractionB, sign);
			}
			else
			{
				result = FractionCalculatorFunctions.calculateFractions(fractionA, fractionB, sign);
			}
			return result;
		}

	}
}
