using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public class FractionClass
	{
		public float numerator;
		public float denominator;

		public void setFractionFromString(string input)
		{
			switch (FractionClassFunctions.getNumberCountInString(input))
			{
				// like (1/2)
				case 2:
					FractionClassFunctions.convertTwoDigitString(ref this.numerator, ref this.denominator, input);
					break;
				// like (1 1/2)
				case 3:
					FractionClassFunctions.convertThreeDigitString(ref this.numerator, ref this.denominator, input);
					break;
				default:
					//something went wrong
					break;
			}
		}
		
		public void convertNumberToFraction(string input)
		{
			this.numerator = Convert.ToSingle(input);
			this.denominator = 1;
		}

		public string returnFractionAsString()
		{
			return ("(" + numerator.ToString() + "/" + denominator.ToString() + ")");
		}






	}
}
