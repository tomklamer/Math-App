using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain.Multiplication
{
    class Vermenigvuldigen_met_een_handig_getal : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 2;
        public string title = "Vermenigvuldigen met een handig getal";

        public void DoAnalyze(string b, string c)
        {
            int firstCheck = Convert.ToInt32(b) % 4;
            int secondCheck = Convert.ToInt32(c) % 25;

            if(firstCheck == 0 && secondCheck == 0)
            {
                this.use = true;
            }

            nextInChain.DoAnalyze(b, c);
        }

        public string ReturnTitle()
        {
            return this.title;
        }

        public ICheckStrategy ReturnStrat()
        {
            if (use)
            {
                return this;
            }

            return null;
        }

        public int ReturnImportance()
        {
            return this.importance;
        }

        public void setNextChain(ICheckStrategy nextChain)
        {
            this.nextInChain = nextChain;
        }
    }
}

