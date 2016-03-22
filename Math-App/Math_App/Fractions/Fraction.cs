using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Fractions
{
	class Fraction
	{
		public string numerator;
		public string denominator;



		public void setNumerator(string input)
		{
			this.numerator = input;
		}

		public void setNumerator(float input)
		{
			this.numerator = input.ToString("G");
		}

		public void setDenominator(string input)
		{
			this.denominator = input;
		}

		public void setDenominator(float input)
		{
			this.denominator = input.ToString("G");
		}

		public void setValue(string input)
		{
			//numerator = StringAnalyzer.getNumerator(input);
			//numerator = StringAnalyzer.getDenominator(input);
		}



	}
}
