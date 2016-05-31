using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class EquationSolver
	{
		public static EquationReturnStruct solveSingleEquation(string input)
		{
			EquationReturnStruct tempStruct = new EquationReturnStruct();
			List<string> numberList = new List<string>();
			List<string> signList = new List<string>();
			StringBuilder sb = new StringBuilder();

			CalculationListBuilder.buildCalculationLists(input, ref numberList, ref signList);
			EquationCalculationManager.calculateSingleEquation(ref tempStruct, numberList, signList);

			return tempStruct;
		}

		public static void showCalculationLists(string input)
		{
			List<string> numberList = new List<string>();
			List<string> signList = new List<string>();
			StringBuilder sb = new StringBuilder();

			CalculationListBuilder.buildCalculationLists(input, ref numberList, ref signList);
		}


		public static void findFractionBeginning(ref int currentPosition, string input)
		{
			while(input[currentPosition] != Const.BRACKET_OPEN_SYMBOL)
			{
				currentPosition--;
			}

		}

		public static void omitFraction(ref int currentPosition, string input)
		{
			while(input[currentPosition] != Const.BRACKET_CLOSE_SYMBOL)
			{
				currentPosition++;
			}
		}
	}
}
