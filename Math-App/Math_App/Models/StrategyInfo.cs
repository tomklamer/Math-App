using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Models
{
    public class StrategyInfo
    {
        public string title;
        public string image;
        public string answer;
        public string equation;

        public StrategyInfo(string a, string b, string c, string d)
        {
            this.title = a;
            this.image = b;
            this.answer = c;
            this.equation = d;
        }
    }
}
