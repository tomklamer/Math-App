using System;
using System.Collections.Generic;
using System.Text;
using Math_App.Logics;


namespace Math_App.Solutions
{
    public class CalculationTypeAnalyzer
    {
        public IStrategyList GetCalcType(string sign, string b, string c)
        {
			if(FractionCheck.hasOnlyFraction(b) || FractionCheck.hasOnlyFraction(c))
			{
				return new Fracture(b, c, sign);
			}

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
                //case "/":
                //    return new Fracture(b, c, sign);
            }
            return null;
        }
    }
}
