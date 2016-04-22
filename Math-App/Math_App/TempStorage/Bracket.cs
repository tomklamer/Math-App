using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.TempStorage
{
    public class Bracket
    {
		string bracketString;
		float solution;
		bool containsBracket;
		int bracketCount;
		int usedBracketCount = 0;
		int signCount;
		public List<string> calculationList = new List<string>();

		public void setString(string equation)
		{
			this.bracketString = equation;
		}

		public string getString()
		{
			return this.bracketString;
		}

		public void addToCalculationList(string argument)
		{
			this.calculationList.Add(argument);
		}

		public float getSolution()
		{

			return solution;
		}

		public void setSolution(float argument)
		{
			this.solution = argument;
		}

		public int getBracketCount()
		{
			return bracketCount;
		}

		public void setBracketCount(int newBracketCount)
		{
			this.bracketCount = newBracketCount;
		}

		public void setContainsBracket(bool argument)
		{
			this.containsBracket = argument;
		}

		public bool getContainsBracket()
		{
			return this.containsBracket;
		}

		public void setSignCount(int count)
		{
			this.signCount = count;
		}

		public int getSignCount()
		{
			return this.signCount;
		}

		//public void printCalculationList()
		//{
		//	foreach (string calculationListt in calculationList)
		//	{
		//		Console.WriteLine("{0}", calculationListt);
		//	}
		//}

		//public void printData()
		//{
		//	Console.WriteLine("Bracket string is:\t {0}", this.bracketString);
		//	Console.WriteLine("Bracket solution is:\t {0}", this.solution);
		//	Console.WriteLine("Contains bracket:\t {0}", this.containsBracket);
		//	Console.WriteLine("Amount of signs:\t {0}", this.signCount);
		//	Console.WriteLine("Amount of brackets is:\t {0}", this.bracketCount);
		//	Console.WriteLine("Calculation List: \t");
		//	Console.WriteLine("");
		//}

	}
}
