using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Logics
{
    public static class TestCases
	{
		public static void prepareTestCases(ref List<string> testEquations)
		{
			// V1 - without numbers below zero

			// A sign B
			testEquations.Add("1 + 2");
			testEquations.Add("11 + 22");
			testEquations.Add("639 + 234");
			testEquations.Add("1 + 998");
			testEquations.Add("1 + 999");
			testEquations.Add("12342 + 98742");

			testEquations.Add("1 x 2");
			testEquations.Add("11 x 22");
			testEquations.Add("639 x 234");
			testEquations.Add("1 x 998");
			testEquations.Add("1 x 999");
			testEquations.Add("2342 x 874");

			testEquations.Add("1 ÷ 2");
			testEquations.Add("11 ÷ 22");
			testEquations.Add("600 ÷ 200");
			testEquations.Add("1 ÷ 998");
			testEquations.Add("1 ÷ 999");
			testEquations.Add("2342 ÷ 8742");

			testEquations.Add("(1 + (2 + (3 + (4 + (5 + (6 - 2 + (17/21) x 20) + 1) + 1 ) + 1) + 1) + 17)");







		}
    }
}
