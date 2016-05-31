using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
    public static class EqCheck
    {
        public static bool isSolved(string input)
        {
			if (CharCheck.isDigit(input) == true)
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
