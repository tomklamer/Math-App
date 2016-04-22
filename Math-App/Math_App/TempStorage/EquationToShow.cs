using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.TempStorage
{
	public class EquationToShow
	{
		public float a;
		public float b;
		public char sign;
		public float solution;


		public void setEquation(float a, float b, char sign, float solution)
		{
			this.a = a;
			this.b = b;
			this.sign = sign;
			this.solution = solution;
		}
	
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
