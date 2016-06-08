using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class EquationCalculationManager
	{
		public static void calculateSingleEquation(ref EquationReturnStruct tempStruct, List<string> numberList, List<string> signList)
		{
			string result = "0";
			int index = 0;

			if(CalculationListCheck.hasMultiplication(signList) == true) 
			{
				index = CalcListElementGet.getFirstMultiplicationIndex(signList);
			}
			else if(CalculationListCheck.hasAddition(signList) == true)
			{
				index = CalcListElementGet.getFirstAdditionIndex(signList);
			}

			result = CalculationPerformer.performCalculation(numberList[index], 
													numberList[index + 1], 
													signList[index]);

			tempStruct.a = numberList[index];
			tempStruct.b = numberList[index + 1];
			tempStruct.sign = signList[index];
			tempStruct.equation = numberList[index] + signList[index] + numberList[index + 1];
			tempStruct.solution = result;
		}
	}
}
