using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class FractionSubstraction
	{
		public static FractionClass Substract(FractionClass a, FractionClass b)
		{
			FractionClass solution = new FractionClass();

			if (a.denominator == b.denominator)
			{
				solution.numerator = a.numerator - b.numerator;
				solution.denominator = a.denominator;
			}
			else
			{
				int LCM = FractionLCM.GetLeastCommonMultiple(a.denominator, b.denominator);
				solution.denominator = LCM;

				solution.numerator = a.numerator * LCM / a.denominator - b.numerator * LCM / b.denominator;
			}
			return solution;

		}
	}
}
