using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Fractions
{
    public static class FractionCalc
    {


        // Fraction Multiplication
        public static Fraction Multiply(Fraction a, Fraction b)
        {
            Fraction solution = new Fraction();

            solution.numerator = a.numerator * b.numerator;
            solution.denominator = a.denominator * b.denominator;
            solution.updateFractionAfterCalculation();


            return solution;
        }

        // Fraction Division
        public static Fraction Divide(Fraction a, Fraction b)
        {
            Fraction solution = new Fraction();

            return a;

        }

        // Fraction Addition
        public static Fraction Add(Fraction a, Fraction b)
        {
            Fraction solution = new Fraction();

            if (a.denominator == b.denominator)
            {
                solution.numerator = a.numerator + b.numerator;
                solution.denominator = a.denominator;
                solution.updateFractionAfterCalculation();
            }
            else
            {
                int LCM = GetLeastCommonMultiple(a.denominator, b.denominator);

                solution.denominator = LCM;

                solution.numerator = a.numerator * LCM / a.denominator + b.numerator * LCM / b.denominator;
                solution.updateFractionAfterCalculation();
            }
            return solution;

        }

        // Fraction Substraction
        public static Fraction Substract(Fraction a, Fraction b)
        {
            Fraction solution = new Fraction();

            if (a.denominator == b.denominator)
            {
                solution.numerator = a.numerator - b.numerator;
                solution.denominator = a.denominator;
                solution.updateFractionAfterCalculation();
            }
            else
            {
                int LCM = GetLeastCommonMultiple(a.denominator, b.denominator);
                solution.denominator = LCM;

                solution.numerator = a.numerator * LCM / a.denominator - b.numerator * LCM / b.denominator;
                solution.updateFractionAfterCalculation();
            }
            return solution;

        }

        public static int GetLeastCommonMultiple(float a, float b)
        {

            int smaller, bigger;

            if (a > b)
            {
                bigger = Convert.ToInt32(a);
                smaller = Convert.ToInt32(b);
            }
            else
            {
                smaller = Convert.ToInt32(a);
                bigger = Convert.ToInt32(b);
            }

            for (int i = 1; i <= smaller; i++)
            {
                if ((i * bigger) % smaller == 0)
                {
                    return i * bigger;
                }
            }
            return smaller * bigger; ;

        }

        public static Fraction ConvertIntToFraction(int input)
        {
            Fraction output = new Fraction();
            output.denominator = 1;
            output.numerator = input;
            output.updateFractionAfterCalculation();

            return output;
        }
    }
}