using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Fractions
{
	class Fraction
	{
		public float numerator = 0;
		public float denominator = 0;
		public float numeratorProper = 0;
		public float unit = 0;

		float value = 0;

		//Convert input string to variables in class
		public void setFraction(string input)
		{
			List<string> result = input.Split(' ').ToList();

			//Case of proper fraction like 2 and 1/5
			if (result.Count() == 4)
			{
				this.unit = (float)Convert.ToDouble(result[0]);
				this.numeratorProper = (float)Convert.ToDouble(result[1]);
				this.denominator = (float)Convert.ToDouble(result[3]);

				this.numerator = this.unit * this.denominator + this.numeratorProper;
			}
			else // case of fraction like 11 / 5
			{
				this.numerator = (float)Convert.ToDouble(result[0]);
				this.denominator = (float)Convert.ToDouble(result[2]);
				if (this.numerator > this.denominator)
				{
					this.updateUnit();
					this.updateNumProper();
				}
				else
				{
					this.numeratorProper = this.numerator;
				}
			}

		}

		//update unit
		void updateUnit()
		{
			float temp = 0;
			int count = 0;
			temp = temp + this.denominator;

			//count the amount of units in fraction
			while (temp < this.numerator)
			{
				temp = temp + this.denominator;
				count++;
			}
			this.unit = this.unit + (float)Convert.ToDouble(count);
		}

		//update numerator proper
		void updateNumProper()
		{
			this.numeratorProper = (this.numerator / this.denominator - this.unit) * this.denominator;
		}

	}
}
