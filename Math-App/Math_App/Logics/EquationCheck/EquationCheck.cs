using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
    public static class EquationCheck
    {
        public static bool isSolved(string input)
        {
			//if (CharCheck.isPartOfDigit(input) == true)
			if(StringCheck.isDigit(input))
			{
				return true;
			}else
			{
				if (FractionCheck.hasOnlyFraction(input) == true)
				{
					return true;
				}
			}
            return false;
        }

        

    }
}
