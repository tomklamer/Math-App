using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Logics.Testing
{
    public static class TestCases
    {
		public static void prepareTestCases()
		{
			List<string> testEquations = new List<string>();

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
			testEquations.Add("2342 x 8742");

		}



    }
}
