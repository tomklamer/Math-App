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
                case "/":
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

        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        public bool leftBracket(string a,string b)
        {
            if (b == "+" || b == "x" || b == "/" || b == ")" || b == "-") return false;
            return true;
        }

        public bool multiply(string a, string b)
        {
            if (b == "-" || b == "/" || b == "x" || b == ")" || b == "+") return false;
            return true;
        }

        public bool devide(string a, string b)
        {
            if (b == "x" || b == "-" || b == ")" || b == "+" || b == "/") return false;
            return true;
        }

        public bool minus(string a, string b)
        {
            if (b == "x" || b == "/" || b == ")" || b == "-" || b == "+") return false;
            return true;
        }

        public bool addition(string a, string b)
        {
            if (b == "x" || b == "/" || b == ")" || b == "-" || b == "+") return false;
            return true;
        }
    }
}
