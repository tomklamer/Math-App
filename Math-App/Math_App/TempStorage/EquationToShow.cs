using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.TempStorage
{
	public class EquationToShow
	{
		//public float a;
		//public float b;
		//public char sign;
		//public float solution;

		public string a;
		public string b;
		public char sign;
		public string solution;


		public void setEquation(float a, float b, char sign, float solution)
		{
			this.a = Convert.ToString(a);
			this.b = Convert.ToString(b);
			this.sign = sign;
			this.solution = Convert.ToString(solution);
		}

		public void setEquation(string a, string b, char sign, string solution)
		{
			this.a = a;
			this.b = b;
			this.sign = sign;
			this.solution = solution;

		}
		
		//public void setEquation(Fractions.Fraction a, Fractions.Fraction b, char sign, float solution)
		//{

		//}
	
		//public void printEquation()
		//{
		//	Console.WriteLine("{0} {1} {2} = {3}", this.a, this.sign, this.b);
		//}

        public string getString()
        {
            string temp;
            temp = this.a + " " + this.sign + " " + this.b;
            return temp;
        }

		


	}

	

}
