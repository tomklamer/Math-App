using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
    public class InputEquation
    {
        public string mainEquation;
        public string solution;

		public List<PartialEquation> partialEquations = new List<PartialEquation>();

		public InputEquation(string inputEq)
        {
			string input = inputEq;
			StringSpaceRemoval.removeSpacesFromString(ref input);
			this.mainEquation = input;

        }

        public void interpretMainEquation()

        {
			string tempMainEquation = mainEquation;
			string topBracket;
			EquationReturnStruct tempStruct = new EquationReturnStruct();

            while(EqCheck.isSolved(tempMainEquation) == false)
			{
				BracketFinder.clearBrackets(ref tempMainEquation);
				if (EqBracketCheck.hasBracketEquation(tempMainEquation) == true)
                {
                    topBracket = BracketFinder.getTopBracket(tempMainEquation);
                    tempStruct = EquationSolver.solveSingleEquation(topBracket);
                    saveSingleEquation(tempStruct);
					//BracketFinder.clearBrackets(ref tempMainEquation);
                    MainEquationUpdater.updateMainTempEquation(ref tempMainEquation, tempStruct);
                }
                else
                {
					tempStruct = EquationSolver.solveSingleEquation(tempMainEquation);
                    saveSingleEquation(tempStruct);
                    MainEquationUpdater.updateMainTempEquation(ref tempMainEquation, tempStruct);
                }
            }
			BracketFinder.clearBrackets(ref tempMainEquation);
			this.solution = partialEquations[partialEquations.Count() - 1].solution;
        }

		public void saveSingleEquation(EquationReturnStruct temp)
		{
			PartialEquation tempPart = new PartialEquation();
			tempPart.a = temp.a;
			tempPart.b = temp.b;
			tempPart.sign = temp.sign;
			tempPart.equation = temp.equation;
			tempPart.solution = temp.solution;

			this.partialEquations.Add(tempPart);
		}
    }
}
