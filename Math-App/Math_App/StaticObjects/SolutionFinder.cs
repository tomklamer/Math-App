using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math_App.TempStorage;
using Math_App.Fractions;

namespace Math_App.StaticObjects
{
    public static class SolutionFinder
    {

        public static void findSolution(int current, List<Bracket> brackets,
                                        MainEquation inputEquation, List<string> calculationList,
                                        Bracket inputBracket)
        {
            char sign = '\0';

            //float a = 0;
            //float b = 0;

            if (calculationList.Count > 1)
            {
                //return '/0';


                string a;
                string b;

                string tempSolution;

                float tempSolutionF;
                //float solutionEnd = 0;
                string solutionEnd = "/0";

                // First loop does the multiplication part
                for (int i = 0; i < calculationList.Count; i++)
                {
                    int j = i;
                    StringBuilder sb = new StringBuilder();

                    // Gets sign from analyzed element of Calculation list ( for example 22+ ) 
                    // and checks if it is multiplication or diivision

                    sign = StringAnalyzer.getSign(calculationList.ElementAt(i));

                    if (sign == 'x' || sign == '÷')
                    {
                        // Get numbers into variables

                        //a = Convert.ToSingle(Analyzer.getNumber(calculationList.ElementAt(i), current, brackets));
                        //b = Convert.ToSingle(Analyzer.getNumber(calculationList.ElementAt(i + 1), current, brackets));

                        a = Analyzer.getNumber(calculationList.ElementAt(i), current, brackets);
                        b = Analyzer.getNumber(calculationList.ElementAt(i + 1), current, brackets);

                        // Remove used element from list
                        calculationList.RemoveAt(i);

                        EquationToShow tempEquation = new EquationToShow();

                        if (Analyzer.isFraction(a) && Analyzer.isFraction(b))
                        {
                            // two fractions
                            tempSolution = performCalculationFraction(a, b, sign).returnFractionNoUnit();
                            tempEquation.setEquation(a, b, sign, tempSolution);
                            sb.Append(tempSolution);
                            //solutionEnd = Convert.ToSingle(tempSolution);
                            solutionEnd = tempSolution;

                        }
                        else if (Analyzer.isFraction(a))
                        {
                            // a is fraction
                            //Fraction tempB = new Fraction();
                            //tempB.setFraction(b);
                            tempSolution = performCalculationFraction(a, b, sign).returnFractionNoUnit();
                            tempEquation.setEquation(a, b, sign, tempSolution);
                            sb.Append(tempSolution);
                            //solutionEnd = Convert.ToSingle(tempSolution);
                            solutionEnd = tempSolution;

                        }
                        else if (Analyzer.isFraction(b))
                        {
                            tempSolution = performCalculationFraction(a, b, sign).returnFractionNoUnit();
                            tempEquation.setEquation(a, b, sign, tempSolution);
                            sb.Append(tempSolution);
                            //solutionEnd = Convert.ToSingle(tempSolution);
                            solutionEnd = tempSolution;
                            // b is fraction
                        }
                        else
                        {
                            // two numbers or brackets

                            tempSolutionF = performCalculation(Convert.ToSingle(a), Convert.ToSingle(b), sign);
                            tempEquation.setEquation(Convert.ToSingle(a), Convert.ToSingle(b), sign, tempSolutionF);
                            sb.Append(Convert.ToString(tempSolutionF));
                            solutionEnd = tempSolutionF.ToString("G");
                        }
                        // one fraction

                        // two numbers or brackets

                        // Perform calculation 
                        //tempSolution = performCalculation(a, b, sign);

                        // Add new EquationToShow to the list

                        //EquationToShow tempEquation = new EquationToShow();

                        //tempEquation.setEquation(Convert.ToSingle(a), Convert.ToSingle(b), sign, Convert.ToSingle(tempSolution));


                        inputEquation.equationsToShow.Add(tempEquation);

                        // Get sign from next element in list
                        sign = StringAnalyzer.getSign(calculationList.ElementAt(i));

                        // Remove next element from list
                        calculationList.RemoveAt(i);

                        // Build string
                        //sb.Append(tempSolution.ToString("G"));
                        //sb.Append(sign);

                        // Build string
                        //sb.Append(tempSolution);
                        sb.Append(sign);

                        // Add new element to list after calculations which replaces two previous elements
                        calculationList.Insert(i, sb.ToString());

                        i--;
                    }
                    else
                    {
                        //solutionEnd = 0;
                        //empty sign
                    }
                }

                // Second loop does the addition / substraction part

                for (int ii = 0; ii < calculationList.Count; ii++) //addition second
                {
                    int j = ii;
                    StringBuilder sbb = new StringBuilder();

                    //	// Gets sign from analyzed element of Calculation list ( for example 22+ ) 
                    //	// and checks if it is addition or substraction

                    //	sign = StringAnalyzer.getSign(calculationList.ElementAt(ii));

                    //	if (sign == '+' || sign == '-')
                    //	{
                    //		// Get numbers into variables
                    //		a = Convert.ToSingle(Analyzer.getNumber(calculationList.ElementAt(ii), current, brackets));
                    //		b = Convert.ToSingle(Analyzer.getNumber(calculationList.ElementAt(ii + 1), current, brackets));

                    //		// Remove used element from list
                    //		calculationList.RemoveAt(ii);

                    //		// Perform calculation
                    //		tempSolution = performCalculation(a, b, sign);

                    //		// Add new EquationToShow to the list
                    //		EquationToShow tempEquation = new EquationToShow();
                    //		tempEquation.setEquation(a, b, sign, tempSolution);
                    //		inputEquation.equationsToShow.Add(tempEquation);

                    //		// Get sign from next element in list
                    //		sign = StringAnalyzer.getSign(calculationList.ElementAt(ii));

                    //		// Remove next element from list
                    //		calculationList.RemoveAt(ii);

                    //		// Build string
                    //		sbb.Append(tempSolution.ToString("G"));
                    //		sbb.Append(sign);

                    //		// Add new element to list after calculations which replaces two previous elements
                    //		calculationList.Insert(ii, sbb.ToString());

                    //		ii--;
                    //	}
                    //	else
                    //	{
                    //		// empty sign, do nothing
                    //	}
                    sign = StringAnalyzer.getSign(calculationList.ElementAt(ii));

                    if (sign == '+' || sign == '-')
                    {
                        // Get numbers into variables

                        //a = Convert.ToSingle(Analyzer.getNumber(calculationList.ElementAt(i), current, brackets));
                        //b = Convert.ToSingle(Analyzer.getNumber(calculationList.ElementAt(i + 1), current, brackets));

                        a = Analyzer.getNumber(calculationList.ElementAt(ii), current, brackets);
                        b = Analyzer.getNumber(calculationList.ElementAt(ii + 1), current, brackets);

                        // Remove used element from list
                        calculationList.RemoveAt(ii);

                        EquationToShow tempEquation = new EquationToShow();

                        if (Analyzer.isFraction(a) && Analyzer.isFraction(b))
                        {
                            // two fractions
                            //tempSolutionF = 0;
                            tempSolution = performCalculationFraction(a, b, sign).returnFractionNoUnit();
                            tempEquation.setEquation(a, b, sign, tempSolution);
                            sbb.Append(tempSolution);
                            //solutionEnd = Convert.ToSingle(tempSolution);
                            solutionEnd = tempSolution;

                        }
                        else if (Analyzer.isFraction(a))
                        {
                            // a is fraction
                            //Fraction tempB = new Fraction();
                            //tempB.setFraction(b);
                            //tempSolutionF = 0;
                            tempSolution = performCalculationFraction(a, b, sign).returnFractionNoUnit();
                            tempEquation.setEquation(a, b, sign, tempSolution);
                            sbb.Append(tempSolution);
                            //solutionEnd = Convert.ToSingle(tempSolution);
                            solutionEnd = tempSolution;

                        }
                        else if (Analyzer.isFraction(b))
                        {
                            //tempSolutionF = 0;
                            tempSolution = performCalculationFraction(a, b, sign).returnFractionNoUnit();
                            tempEquation.setEquation(a, b, sign, tempSolution);
                            sbb.Append(tempSolution);
                            //solutionEnd = Convert.ToSingle(tempSolution);
                            solutionEnd = tempSolution;

                            // b is fraction
                        }
                        else
                        {
                            // two numbers or brackets
                            //tempSolution = "0";
                            tempSolutionF = performCalculation(Convert.ToSingle(a), Convert.ToSingle(b), sign);
                            tempEquation.setEquation(Convert.ToSingle(a), Convert.ToSingle(b), sign, tempSolutionF);
                            sbb.Append(Convert.ToString(tempSolutionF));
                            solutionEnd = tempSolutionF.ToString("G");
                        }

                        //if(Analyzer.isFraction(a) || Analyzer.isFraction(b))
                        //{
                        //	solutionEnd = Convert.ToSingle(tempSolution);
                        //}else
                        //{
                        //	solutionEnd = tempSolutionF;
                        //}




                        // one fraction

                        // two numbers or brackets

                        // Perform calculation 
                        //tempSolution = performCalculation(a, b, sign);

                        // Add new EquationToShow to the list

                        //EquationToShow tempEquation = new EquationToShow();

                        //tempEquation.setEquation(Convert.ToSingle(a), Convert.ToSingle(b), sign, Convert.ToSingle(tempSolution));


                        inputEquation.equationsToShow.Add(tempEquation);

                        // Get sign from next element in list
                        sign = StringAnalyzer.getSign(calculationList.ElementAt(ii));

                        // Remove next element from list
                        calculationList.RemoveAt(ii);

                        // Build string
                        //sb.Append(tempSolution.ToString("G"));
                        //sb.Append(sign);

                        // Build string
                        //sbb.Append(tempSolution);
                        sbb.Append(sign);

                        // Add new element to list after calculations which replaces two previous elements
                        calculationList.Insert(ii, sbb.ToString());

                        ii--;
                    }
                    else
                    {
                        //empty sign
                        //solutionEnd = 0;
                    }




                }


                inputBracket.setSolution(solutionEnd);
            }
            else
            {
                // too small calculation list, do nothing
            }

        }

        public static float performCalculation(float a, float b, char sign)
        {
            float solution = 0;
            switch (sign)
            {
                case 'x':
                    {
                        solution = a * b;
                        break;
                    }
                case '÷':
                    {
                        solution = a / b;
                        break;
                    }
                case '+':
                    {
                        solution = a + b;
                        break;
                    }
                case '-':
                    {
                        solution = a - b;
                        break;
                    }
            }
            return solution;
        }

        public static Fraction performCalculationFraction(string inputA, string inputB, char sign)
        {
            Fraction a = new Fraction();
            Fraction b = new Fraction();

            a.setFraction(inputA);
            b.setFraction(inputB);

            Fraction solution = new Fraction();
            switch (sign)
            {
                case 'x':
                    {
                        solution = FractionCalc.Multiply(a, b);
                        break;
                    }
                case '÷':
                    {
                        solution = FractionCalc.Divide(a, b);
                        break;
                    }
                case '+':
                    {
                        solution = FractionCalc.Add(a, b);
                        break;
                    }
                case '-':
                    {
                        solution = FractionCalc.Substract(a, b);
                        break;
                    }

            }
            return solution;
        }



    }
}