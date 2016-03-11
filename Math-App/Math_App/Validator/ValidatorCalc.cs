using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Validator
{
    public class ValidatorCalc
    {

        public bool checkCharacters(string a, string b)
        {
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
            return true;
        }

        public bool leftBracket(string a,string b)
        {
            if (b == ")") return false;
            if (b == "+" || b == "x" || b == "/") return false;
            return true;
        }

        public bool multiply(string a, string b)
        {
            if (b == "-" || b == "/" || b == "x" || b == ")") return false;
            return true;
        }

        public bool devide(string a, string b)
        {
            if (b == "x" || b == "-" || b == ")" || b == "+" || b == "/") return false;
            return true;
        }

        public bool minus(string a, string b)
        {
            if (b == "x" || b == "/" || b == ")" || b == "-") return false;
            return true;
        }

        public bool addition(string a, string b)
        {
            if (b == "x" || b == "/" || b == ")" || b == "-") return false;
            return true;
        }
    }
}
