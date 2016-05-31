using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class FractionMultiplication
	{
		public static FractionClass Multiply(FractionClass a, FractionClass b)
		{
			FractionClass solution = new FractionClass();

			solution.numerator = a.numerator * b.numerator;
			solution.denominator = a.denominator * b.denominator;
			return solution;
		}
	}
}
