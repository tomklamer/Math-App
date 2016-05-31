using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class FractionDivision
	{
		public static FractionClass Divide(FractionClass a, FractionClass b)
		{
			FractionClass solution = new FractionClass();

			solution.numerator = a.numerator * b.denominator;
			solution.denominator = a.denominator * b.numerator;

			return a;

		}
	}
}
