using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain.Multiplication
{
     class Vermenigvuldigen_met_1x_meer : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 3;
        public string title = "Vermenigvuldigen met 1x meer";

        public void DoAnalyze(string b, string c)
        {
            if (Convert.ToInt32(b) == 6 || Convert.ToInt32(c) == 6 ||
                Convert.ToInt32(b) == 11 || Convert.ToInt32(c) == 11)
            {
                this.use = true;
            }

            if (nextInChain != null)
            {
                nextInChain.DoAnalyze(b, c);
            }
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

