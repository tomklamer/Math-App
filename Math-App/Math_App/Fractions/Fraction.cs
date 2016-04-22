using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Fractions
{
	public class Fraction
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
			result = result.Where(s => s != "").ToList();

			// temporary solution - remove bracket signs from string
			//result = result.Where(s => s != "(").ToList();

			//result = result.Where(s => s != ")").ToList();

			//result = result.Where(s => s != ")").ToList();
			if(result.Count == 5)
			{
				result.RemoveAt(4);
				result.RemoveAt(0);
			}
			


			//Case of proper fraction like 2 and 1/5
			if (result.Count() == 4)
			{
				this.unit = Convert.ToSingle(result[0]);
				this.numeratorProper = Convert.ToSingle(result[1]);
				this.denominator = Convert.ToSingle(result[3]);

				this.numerator = this.unit * this.denominator + this.numeratorProper;
			}
			else if(result.Count() == 3) // case of fraction like 11 / 5
			{
				this.numerator = Convert.ToSingle(result[0]);
				this.denominator = Convert.ToSingle(result[2]);
				if (this.numerator > this.denominator)
				{
					this.updateUnit();
					this.updateNumProper();
				}
				else
				{
					this.numeratorProper = this.numerator;
				}
			}else if(result.Count() == 1)
			{
				this.numerator = Convert.ToSingle(result[0]);
				this.denominator = 1;

			}

		}

		public void updateFractionAfterCalculation()
		{
			// The case where we have only numerator and denominator

			// 11 / 5 for example
			if(this.numerator > this.denominator)
			{
				this.updateUnit();
				this.updateNumProper();
			}
			else
			// Classic case like 4 / 5
			{
				this.numeratorProper = this.numerator;
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

		public string returnFractionNoUnit()
		{
			//StringBuilder sb = new StringBuilder();
			//sb.Append('(');
			//sb.Append(Convert.ToString(this.numerator));
			//sb.Append(" / ");
			//sb.Append(Convert.ToString(this.denominator));
			//sb.Append(')');
			//return sb.ToString();

			string temp = "( "  + Convert.ToString(this.numerator) + " / " + Convert.ToString(this.denominator) + " )";
			return temp;
		}

		public string returnFractionUnit()
		{
			//StringBuilder sb = new StringBuilder();
			//sb.Append('(');
			//sb.Append(Convert.ToString(this.unit));
			//sb.Append(' ');
			//sb.Append(Convert.ToString(this.numeratorProper));
			//sb.Append(" / ");
			//sb.Append(Convert.ToString(this.denominator));
			//sb.Append(')');

			string temp = "( " + Convert.ToString(this.unit) + ' ' + Convert.ToString(this.numeratorProper) + " / " + Convert.ToString(this.denominator) + " )";

			//return sb.ToString();
			return temp;

		}


	}
}
