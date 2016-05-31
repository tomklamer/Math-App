using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class CalculationPerformer
	{
		public static string performCalculation(string a, string b, string sign)
		{
			string result = null;
			if (FractionCheck.hasOnlyFraction(a) || FractionCheck.hasOnlyFraction(b))
			{
				result = FractionCalculator.calculate(a, b, sign);
			}else
			{
				result = RegularCalculator.calculate(a, b, sign);
			}
			return result;
		}
	}
}
