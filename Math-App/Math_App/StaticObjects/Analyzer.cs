using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math_App.TempStorage;
using System.Diagnostics;

namespace Math_App.StaticObjects
{
    public static class Analyzer
    {
        public static void getBrackets(string equation, List<Bracket> brackets)
        {
            List<int> usedBrackets = new List<int>();

            for (int openCursor = 0; openCursor < equation.Length; openCursor++)
            {
                // 'openCursor + 1' - Value is increased by one in all cases 
                // Zero here also means false.

                // Look for opening for bracket and check if it was found earlier

                if (equation[openCursor] == '(' && usedBrackets.Find(x => x == (openCursor + 1)) == 0)
                {
                    // Once opening is found I start looking for bracket closing
                    // from the place an opening was found

                    for (int closeCursor = openCursor; closeCursor < equation.Length; closeCursor++)
                    {
                        // I keep going left until closing is found

                        if (equation[closeCursor] == ')' && usedBrackets.Find(x => x == (closeCursor + 1)) == 0)
                        {
                            // Closing found and its index added to usedBrackets list

                            usedBrackets.Add(closeCursor + 1);

                            // Look back for the first bracket opening

                            for (int openCursorBis = closeCursor; openCursorBis >= 0; openCursorBis--)
                            {
                                // If found add it to used brackets 

                                if (equation[openCursorBis] == '(' && usedBrackets.Find(x => x == (openCursorBis + 1)) == 0)
                                {
                                    usedBrackets.Add(openCursorBis + 1);
                                    Bracket tempBracket = new Bracket();

                                    // get string inside the bracket

                                    tempBracket.setString(getEquationFragment((openCursorBis + 1), (closeCursor - 1), equation));

                                    brackets.Add(tempBracket);
                                    break;
                                }
                            }

                        }
                    }
                }
            }
            // Create a bracket with whole equation 
            // string in it since it is ommited in code

            Bracket tempBracketBis = new Bracket();
            tempBracketBis.setString(equation);
            brackets.Add(tempBracketBis);
        }

        // Returns string from begin index to the end

        public static string getEquationFragment(int begin, int end, string equation)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = begin; i <= end; i++)
            {
                sb.Append(equation[i]);
            }

            //string tempString = sb.ToString();
            //return tempString;

            return sb.ToString();
        }

        public static void buildCalculationList(MainEquation equation)
        {
            int index = 0;
            foreach (Bracket bracket in equation.brackets)
            {
                //if (isFraction(bracket.getString()))
                if (hasSign(bracket.getString()) == false)
                {
                    bracket.addToCalculationList(bracket.getString());
                }
                else {
                    index = 0;
                    StringBuilder sb = new StringBuilder();

                    // Go through whole string in bracket and
                    // Convert it to strings of <number / bracket> <sign>
                    // for example 
                    // 2 +
                    // 3-
                    // (4-3)+
                    // 2

                    while (index + 1 < bracket.getString().Length)
                    {
                        //Debug.WriteLine("Index is {0}", index);
                        //Get number / bracket first
                        sb.Append(getNumberOrBracket(bracket.getString(), ref index));

                        //Then get sign
                        sb.Append(getSign(bracket.getString(), ref index));

                        //End of element - add it to Calculation List 
                        bracket.addToCalculationList(sb.ToString());

                        sb.Clear();
                    }
                }
                //Console.WriteLine("Build Calculation List: ");
            }
        }

        // Returns first number or bracket from startNum index, modifies index variable

        public static string getNumberOrBracket(string equation, ref int curIndex)
        {
            StringBuilder sb = new StringBuilder();
            int numBracketOpen = 0;
            int numBracketClose = 0;

            // Go through string

            for (int i = curIndex; i < equation.Length; i++)
            {
                // Number Found

                if (Char.IsNumber(equation[i]))
                {
                    // Append till the end of number
                    while (Char.IsNumber(equation[i]))
                    {
                        sb.Append(equation[i]);
                        i++;
                        if (i >= equation.Length)
                        {
                            break;
                        }
                    }
                    curIndex = i + 1;
                    break;
                }
                else if (equation[i] == '(')

                // Bracket opening found

                {
                    sb.Append(equation[i]);
                    numBracketOpen++;

                    // Append till the end of brackets
                    // Number of openings and closings must be the same
                    // and not zero

                    do
                    {
                        i++;
                        sb.Append(equation[i]);
                        if (equation[i] == '(')
                        {
                            numBracketOpen++;
                        }
                        else if (equation[i] == ')')
                        {
                            numBracketClose++;
                        }
                    } while (numBracketOpen != numBracketClose);
                    curIndex = i + 1;
                    break;
                }
                curIndex = i + 1;
            }
            return sb.ToString();
        }

        // Returns first sign from startNum index, modifies index variable

        public static char getSign(string equation, ref int curIndex)
        {
            for (int i = curIndex; i < equation.Length; i++)
            {
                if (isSign(equation[i]))
                {
                    //Debug.WriteLine("{0} has a sign", equation);
                    return equation[i];
                }
            }
            //Debug.WriteLine("{0} has no sign", equation);
            return '\0';
        }

        // Checks if input char is a sign

        public static bool isSign(char toCheck)
        {
            if (toCheck == '+' ||
                toCheck == '-' ||
                toCheck == 'x' ||
                toCheck == '÷')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool hasSign(string toCheck)
        {
            for (int i = 0; i < toCheck.Length; i++)
            {
                if (isSign(toCheck[i]))
                {
                    Debug.WriteLine("{0} has a sign", toCheck);
                    return true;
                }
            }
            Debug.WriteLine("{0} has no sign", toCheck);
            return false;
        }


        public static bool isFraction(string toCheck)
        {
            for (int i = 0; i < toCheck.Length; i++)
            {
                if (toCheck[i] == '/')
                {
                    Debug.WriteLine("{0} is fraction", toCheck);

                    return true;
                }
            }
            Debug.WriteLine("{0} is not a fraction", toCheck);
            return false;
        }

        // Gets number from prepared into of format <number><sign>
        // In case of bracket it returns the solution of bracket equation

        public static string getNumber(string stringToCheck, int curBracket, List<Bracket> brackets)
        {
            StringBuilder sb = new StringBuilder();
            bool containsBracket = false;
            bool hasSign = false;
            bool isFraction = false;
            // Go through string

            for (int i = 0; i < stringToCheck.Length; i++)
            {
                int bracketCount = brackets[curBracket].getBracketCount() - 1;

                // Look for sign

                // No sign
                // Number or bracket opening
                if (isSign(stringToCheck[i]) == false)
                {
                    // Check if there is bracket opening

                    if (stringToCheck[i] == '(')
                    {
                        containsBracket = true;
                    }
                    else if (stringToCheck[i] == '/')
                    {
                        isFraction = true;
                    }

                    // Append digit or bracket opening

                    sb.Append(stringToCheck[i]);


                }
                else
                // Encounters sign
                {
                    hasSign = true;
                    if (containsBracket == true)
                    {
                        if (brackets[curBracket].getBracketCount() > 1)
                        {
                            // More than one bracket

                            for (int j = curBracket; j >= 0; j--)
                            {
                                // Go through other brackets from curBracket to 0

                                // If checked bracket does not contain another bracket
                                // reduce number of bracketCount
                                // BracketCount - number of empty brackets to omit
                                // before finding the one you are looking for

                                if (brackets[j].getContainsBracket() == false)
                                {
                                    bracketCount--;
                                    if (bracketCount == 0)
                                    {
                                        // Reduce BracketCount by one

                                        brackets[curBracket].setBracketCount(brackets[curBracket].getBracketCount() - 1);
                                        //if (isFraction)
                                        //{
                                        //	return sb.ToString();
                                        //}

                                        return brackets[j - 1].getSolution();
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Single bracket - return its solution
                            //if (isFraction)
                            //{
                            //	return sb.ToString();
                            //}
                            return brackets[curBracket - 1].getSolution();
                        }
                        //if (isFraction)
                        //{
                        //	return sb.ToString();
                        //}
                        return brackets[curBracket - 1].getSolution();
                    }
                    break;
                }
            }
            return sb.ToString();
        }
    }
}