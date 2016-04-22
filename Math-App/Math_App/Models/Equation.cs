using System;
using System.Collections.Generic;
using System.Text;
using Math_App.TempStorage;

namespace Math_App.Models
{
    public class Equation
    {
        public string completeAnswer;
        public string completeEquation;
        public string partEquation;
        public string partAnswer;
        public string image;
        public float a;
        public float b;
        public char sign;

        public Equation(string a, string b, string c, string d, float e, float f, char g)
        {
            this.completeAnswer = a;
            this.completeEquation = b;
            this.partEquation = c;
            this.partAnswer = d;
            this.a = e;
            this.b = f;
            this.sign = g;
        }
    }
}
