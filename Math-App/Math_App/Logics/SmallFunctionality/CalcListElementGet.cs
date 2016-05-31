using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class CalcListElementGet
	{
		public static int getFirstMultiplicationIndex(List<string> signList)
		{
			for(int i = 0; i < signList.Count(); i++)
			{
				if(signList[i] == Const.MULTIPLY_SYMBOL.ToString() 
					|| signList[i] == Const.DIVIDE_SYMBOL.ToString())
				{
					return i;
				}
			}

			// Should not happen, checked earlier 
			// in calculationListCheck.hasMultiplication

			return 0;

		}

		public static int getFirstAdditionIndex(List<string> signList)
		{
			for (int i = 0; i < signList.Count(); i++)
			{
				if (signList[i] == Const.PLUS_SYMBOL.ToString()
					|| signList[i] == Const.MINUS_SYMBOL.ToString())
				{
					return i;
				}
			}

			// Should not happen, checked earlier 
			// in calculationListCheck.hasAddition
			return 0;


		}
	}
}
