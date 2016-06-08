using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Logics
{
    public static class TestPerformer
    {
		public static void test(List<string> testEquations)
		{
			foreach(string element in testEquations)
			{
				InputEquation test = new InputEquation(element);
				test.interpretMainEquation();
			}
		}
    }
}
