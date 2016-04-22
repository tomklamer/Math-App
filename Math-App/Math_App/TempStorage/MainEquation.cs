using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math_App.StaticObjects;

namespace Math_App.TempStorage
{
// Main equation class contains all info about equation
// It interprets equation
// EquationToShow is a list of single equations displayed in app
// 

	public class MainEquation
	{
		public string equation = "0";
		public string solution = "0";

		public List<Bracket> brackets = new List<Bracket>();
		public List<EquationToShow> equationsToShow = new List<EquationToShow>();

        public List<string> getEquationsStrings()
        {
            List<string> temp = new List<string>();
            foreach(EquationToShow element in equationsToShow){
                temp.Add(element.getString());
            }
            return temp;
        }
        public List<string> getEquationsSolution()
        {
            List<string> temp = new List<string>();
            foreach (EquationToShow element in equationsToShow)
            {
                temp.Add(element.solution.ToString());
            }
            return temp;
        }


		//public List<String>

		public void setString(string equation)
		{
			this.equation = equation;
		}
		public string getString()
		{
			return this.equation;
		}

		public string getSolution()
		{
			return this.solution;
		}

		public void buildBrackets()
		{
			Analyzer.getBrackets(equation, brackets);
			Analyzer.buildCalculationList(this);

			for (int curBracket = 0; curBracket < brackets.Count; curBracket++)
			{
				BracketAnalyzer.checkForBrackets(brackets[curBracket]);
				BracketAnalyzer.countBrackets(brackets[curBracket]);
				SolutionFinder.findSolution(curBracket, brackets, this, 
											brackets[curBracket].calculationList, 
											brackets[curBracket]);
			}
            this.solution = this.equationsToShow.ElementAt(this.equationsToShow.Count() - 1).solution;
		}

		//public void printBracketsInfo()
		//{
		//	for (int i = 0; i < brackets.Count; i++)
		//	{
		//		brackets[i].printData();
		//	}
		//}

		//public void printAllEquationsToShow()
		//{
		//	foreach(EquationToShow equation in equationsToShow)
		//	{
		//		equation.printEquation();
		//	}
		//}

		public void testSequence(string inputString)
		{
			this.equation = inputString;
			this.buildBrackets();
			//this.printBracketsInfo();
			//this.printAllEquationsToShow();
		}


}

}
