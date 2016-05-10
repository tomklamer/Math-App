using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions
{
    public class CalculationTypeAnalyzer
    {
        public IStrategyList GetCalcType(string sign, string b, string c)
        {
            switch (sign)
            {
                case "-":
                    return new Minus(b, c);
                case "+":
                    return new Addition(b, c);
                case "÷":
                    return new Devide(b, c);
                case "x":
                    return new Multiply(b, c);
                case "fracture??":
                    return new Fracture(b, c);
            }
            return null;
        }
    }
}
