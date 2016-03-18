using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions
{
    public class CalculationTypeAnalyzer
    {
        public IStrategyList GetStrategyType(string a, string b)
        {
            switch (a)
            {
                case "-":
                    return new Minus();
                case "+":
                    return new Addition();
                case "/":
                    return new Devide();
                case "x":
                    return new Multiply();
                case "fracture??":
                    return new Fracture();
            }
            return null;
        }
    }
}
