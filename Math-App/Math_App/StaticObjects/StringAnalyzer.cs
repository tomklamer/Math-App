using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Math_App.StaticObjects
{
    public static class StringAnalyzer
    {
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

        public static char getSign(string toCheck)
        {
            int openBracket = 0;
            int closeBracket = 0;
            for (int i = 0; i < toCheck.Length; i++)
            {
                if (toCheck[i] == '(')
                {
                    openBracket++;
                }
                else if (toCheck[i] == ')')
                {
                    closeBracket++;
                }
                if (openBracket == closeBracket)
                {
                    if (toCheck[i] == '+' ||
                    toCheck[i] == '-' ||
                    toCheck[i] == 'x' ||
                    toCheck[i] == '÷')
                    {
                        return toCheck[i];
                    }
                }
            }
            return '\0';
        }

        public static int getPositionSign(char sign1, char sign2, string bracketString)
        {
            int position = -1;
            for (int i = 0; i < bracketString.Length; i++)
            {
                if (bracketString[i] == sign1 || bracketString[i] == sign2)
                {
                    position = i;
                    break;
                }
            }
            return position;
        }

        public static string AddStrings(string a)
        {
            var withSpaces = a.Aggregate(string.Empty, (c, i) => c + i + ' ');
            var end = Regex.Replace(withSpaces, @"(?<=\d)\p{Zs}(?=\d)", "");
            return end;
        }
    }
}