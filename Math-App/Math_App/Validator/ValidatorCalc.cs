using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Validator
{
    public class ValidatorCalc
    {

        // Validator for calculation string input
        public bool checkCharacters(string a, string b)
        {
            if (string.IsNullOrEmpty(a))
            {
                return false;
            }

            switch (a)
            {
                case "(":
                    return leftBracket(a, b);
                case "+":
                    return addition(a, b);
                case "-":
                    return minus(a, b);
                case "÷":
                    return devide(a, b);
                case "x":
                    return multiply(a, b);
            }

            if (IsDigitsOnly(a))
            {
                if (b == "(") return false;
            }

            return true;
        }
         
        // check for unwanted zeroes
        public bool checkZero(string str)
        {
            if (str == "") return false;
            char lastChar = str[str.Length - 1];
            if (lastChar == 'x' || lastChar == '-' || lastChar == '+'
                || lastChar == '÷' || lastChar == '(' || lastChar == ')') return false;
            return true;
        }

        // check last char
        public bool lastChar(string a)
        {
            if (a == "x" || a == "-" || a == "+" || a == "÷" || a == "(") return false;
            return true;
        }

        // check only digits
        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        // check leftbracket
        public bool leftBracket(string a,string b)
        {
            if (b == "+" || b == "x" || b == "÷" || b == ")" || b == "-" ) return false;
            return true;
        }

        // check multiply
        public bool multiply(string a, string b)
        {
            if (b == "-" || b == "÷" || b == "x" || b == ")" || b == "+" ) return false;
            return true;
        }

        // check devide
        public bool devide(string a, string b)
        {
            if (b == "x" || b == "-" || b == ")" || b == "+" || b == "÷" ) return false;
            return true;
        }

        // check minus
        public bool minus(string a, string b)
        {
            if (b == "x" || b == "÷" || b == ")" || b == "-" || b == "+" ) return false;
            return true;
        }

        // check addition
        public bool addition(string a, string b)
        {
            if (b == "x" || b == "÷" || b == ")" || b == "-" || b == "+" ) return false;
            return true;
        }

        // create fraction
        public string CreateFraction(string b, string c)
        {
            if (b.Length != 0 && c.Length != 0)
            {
                string tempString = "(" + b + "/" + c + ")";
                return tempString;
            }
            return "";
        }
    }
}
