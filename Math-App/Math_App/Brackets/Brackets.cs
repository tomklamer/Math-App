using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Math_App.Brackets
{
    public class Brackets
    {
        string equationBrackets;
        List<string> list = new List<string>();
        List<int> levels = new List<int>();
        string equationConverted;
        char equationSign;

        public Brackets()
        {
            // assignEquationType();
        }

        public void initiateEquation()
        {
            equationSign = readSign();
        }

        public void setEquationBrackets(string equation)
        {
            this.equationBrackets = equation;
        }

        public char returnSign()
        {
            return equationSign;
        }

        public string returnEquationConverted()
        {
            return equationConverted;
        }

        public string returnEquationBrackets()
        {
            return equationBrackets;
        }

        public List<string> returnList()
        {
            return list;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Title <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        // uitleg!!!!!!!
        public char readSign()
        {
            int i = 0;
            while (i < equationConverted.Length)
            {
                if (equationConverted[i] == '+' ||
                   equationConverted[i] == '-' ||
                   equationConverted[i] == '*' ||
                   equationConverted[i] == '/')
                {
                    //Console.WriteLine("Got Sign!");
                    return equationConverted[i];
                }
                i++;
            }
            return '\0'; //invalid equation
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Title <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        // uitleg!!!!!!!
        public void dropBrackets()
        {
            this.equationConverted = this.equationBrackets;

            for (int i = 0; i < equationConverted.Length; i++)
            {
                if (equationConverted[i] == ')')
                {
                    for (int j = i; j >= 0; j--)
                    {
                        if (equationConverted[j] == '(')
                        {
                            StringBuilder sb = new StringBuilder(this.equationConverted);
                            sb[i] = '\0';
                            sb[j] = '\0';
                            this.equationConverted = sb.ToString();
                            //Console.WriteLine("Found a bracket!");
                            //Console.WriteLine(i);
                            //Console.WriteLine(j);
                            break;
                        }
                    }
                }
            }
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Title <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        // uitleg!!!!!!!
        public void getBrackets()
        {
            List<int> openPos = new List<int>();
            List<int> closePos = new List<int>();
            List<string> bracketPairs = new List<string>();

            List<int> usedBrackets = new List<int>();
            int indexer = 0;

            for (int openCursor = 0; openCursor < equationBrackets.Length; openCursor++) //I increase values in used Bracket List by 1 so that when I look for 0, I actually look for 1. Zero here also means false.
            {
                if (equationBrackets[openCursor] == '(' && usedBrackets.Find(x => x == (openCursor + 1)) == 0)
                {
                    for (int closeCursor = openCursor; closeCursor < equationBrackets.Length; closeCursor++)
                    {
                        if (equationBrackets[closeCursor] == ')' && usedBrackets.Find(x => x == (closeCursor + 1)) == 0)
                        {
                            usedBrackets.Add(closeCursor + 1);
                            for (int openCursorBis = closeCursor; openCursorBis >= 0; openCursorBis--)
                            {
                                if (equationBrackets[openCursorBis] == '(' && usedBrackets.Find(x => x == (openCursorBis + 1)) == 0)
                                {
                                    //indexer += 1;
                                    usedBrackets.Add(openCursorBis + 1);
                                    //Console.WriteLine("Found a bracket from {0} to {1}", openCursorBis, closeCursor);
                                    //Console.WriteLine(getEquationFragment(openCursorBis, closeCursor));
                                    //Console.WriteLine(indexer);
                                    list.Add(getEquationFragment(openCursorBis, closeCursor));
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Title <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        // Check if the order is correct  >>>>>>>> buitenste haakjes fixen
        public bool isCorrectOrder(string a)
        {
            List<string> list = new List<string>();
            var regexItem = new Regex("^[(-) ]*$");

            foreach (char c in a)
            {
                if (regexItem.IsMatch(c.ToString()))
                {
                    list.Add(c.ToString());
                }
            }

            if (list.Count != 0)
            {

                int counta = 0;
                int countb = 0;

                foreach (string item in list)
                {
                    if (item == "(")
                    {
                        counta += 1;
                    }
                    else
                    {
                        countb += 1;
                    }
                }

                if (counta != countb && counta != 0 && countb != 0)
                {
                    return false;
                }
                else
                {
                    return checkOrder(list, list.Count / 2);
                }
            }

            return false;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Title <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        // check if everything is closed
        public bool checkOrder(List<string> lijst, int a)
        {
            bool value = false;
            string tempChar = "x";
            int counter = 0;
            for (int i = 0; i < lijst.Count; i++)
            {
                if (tempChar != "x")
                {
                    if (tempChar != lijst[i].ToString())
                    {
                        lijst.RemoveAt(i);
                        lijst.RemoveAt(i - 1);
                        tempChar = "x";
                        counter += 2;
                    }
                    else
                    {
                        tempChar = lijst[i].ToString();
                    }
                }
                else
                {
                    tempChar = lijst[i].ToString();
                }
            }

            if (lijst.Count == 0)
            {
                value = true;
            }
            else if (a > 0)
            {
                value = checkOrder(lijst, a - 1);
            }

            return value;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Title <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        // uitleg!!!!!!!
        public string getEquationFragment(int begin, int end)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = begin; i <= end; i++)
            {
                sb.Append(equationBrackets[i]);
            }
            string tempString = sb.ToString();
            return tempString;
        }


        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Title <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        // funtion for removing spaces in a string
        public string removeSpace(string a)
        {
            return Regex.Replace(a, @"\s+", "");
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Title <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        // function for reversing string
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Title <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        // Check if the correct chars are used
        public bool isCorrectChars(string a)
        {
            var regexItem = new Regex("^[+-_-*-/-1-2-3-4-5-6-7-8-9 ]*$");

            if (!regexItem.IsMatch(a))
            {
                return false;
            }

            return true;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Title <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        // uitlegg!! <<<<<<<<
        public List<string> getValues(string a)
        {
            List<string> lijst = new List<string>();

            string tempStringNumber = null;
            foreach (char c in a)
            {
                if (new Regex("^[1-2-3-4-5-6-7-8-9 ]*$").IsMatch(c.ToString()))
                {
                    tempStringNumber += c.ToString();
                }
                else if (new Regex("^[+-_-*-/ ]*$").IsMatch(c.ToString()))
                {
                    if (tempStringNumber != null)
                    {
                        lijst.Add(tempStringNumber);
                        tempStringNumber = null;
                    }
                    lijst.Add(c.ToString());
                }
                else if (new Regex("^[(-) ]*$").IsMatch(c.ToString()))
                {
                    if (tempStringNumber != null)
                    {
                        lijst.Add(tempStringNumber);
                        tempStringNumber = null;
                    }
                    lijst.Add(c.ToString());
                }
            }

            if (tempStringNumber != null)
            {
                lijst.Add(tempStringNumber);
            }

            return lijst;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Title <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        // uitleg!! <<<<<<<<<<
        public bool containsBrackets(string a)
        {
            if (a.Contains("(") || a.Contains(")"))
            {
                return true;
            }

            return false;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Title <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        // uitleg!! <<<<<<<<<<
        public bool operatorOrder(string a)
        {
            if (a.Contains("_+") || a.Contains("*+") || a.Contains("/+") ||
                a.Contains("+_") || a.Contains("/_") || a.Contains("*_") ||
                a.Contains("_*") || a.Contains("/*") || a.Contains("+*"))
            {
                return false;
            }

            return true;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Title <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        // uitleg!! <<<<<<<<<
        public bool operatorNextToBrackets(string a)
        {
            if (a.Contains("(+") || a.Contains("(_") || a.Contains("(*") ||
                a.Contains("(/") || a.Contains("+)") || a.Contains("_)") ||
                a.Contains("*)") || a.Contains("/)"))
            {
                return false;
            }

            return true;
        }
    }
}
