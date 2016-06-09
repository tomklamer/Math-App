using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Math_App.Logics
{
	public static class TestMainClass
	{
		public static void performTests()
		{
			List<string> testEquations = new List<string>();

			TestCases.prepareTestCases(ref testEquations);
			TestPerformer.test(testEquations);
		}
	}
}

