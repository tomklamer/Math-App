using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class MainEquationUpdater
	{
		public static void updateMainTempEquation(ref string tempMainEquation, EquationReturnStruct tempStruct)
		{
			string equationToReplace = tempStruct.equation;
			string equationSolution = tempStruct.solution;
			StringBuilder sb = new StringBuilder();
			int startIndex = 0;
			int endIndex = 0;
			bool loopIsDone = false;

			int replaceIndex = 0;

			BracketFinder.clearBrackets(ref tempMainEquation);
			for(int i = 0; i < tempMainEquation.Length; i++)
			{
				if(tempMainEquation[i] == equationToReplace[replaceIndex])
				{

				startIndex = i;
					while (tempMainEquation[i] == equationToReplace[replaceIndex])
					{
						i++;
						replaceIndex++;
						if(replaceIndex == equationToReplace.Length)
						{
							endIndex = i - 1;
							loopIsDone = true;
						}

						if (loopIsDone == true)
						{
							break;
						}
					}


				}
				if (loopIsDone == true)
				{
					break;
				}else
				{
					startIndex = 0;
					endIndex = 0;
					if(replaceIndex != 0)
					{
						i--;
					}
					replaceIndex = 0;
				}
			}

			sb.Append(tempMainEquation);
			sb.Remove(startIndex, endIndex - startIndex + 1);
			sb.Insert(startIndex, equationSolution);

			tempMainEquation = sb.ToString();
		}


	}
}
