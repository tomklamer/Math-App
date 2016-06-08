using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class CalculationListCheck
	{
		public static bool hasMultiplication(List<string> signList)
		{
			foreach(string element in signList)
			{
				if(element == Const.MULTIPLY_SYMBOL.ToString() 
					|| element == Const.DIVIDE_SYMBOL.ToString())
				{
					return true;
				}
			}

			return false;
		}

		public static bool hasAddition(List<string> signList)
		{
			foreach (string element in signList)
			{
				if (element == Const.PLUS_SYMBOL.ToString()
					|| element == Const.MINUS_SYMBOL.ToString())
				{
					return true;
				}
			}

			return false;
		}


	}
}
