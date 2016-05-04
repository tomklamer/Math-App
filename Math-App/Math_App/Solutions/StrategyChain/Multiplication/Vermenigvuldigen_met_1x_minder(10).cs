using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain.Multiplication
{
    public class Vermenigvuldigen_met_1x_minder_10 : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 4;
        public string title = "Vermenigvuldigen met 1x minder (10)";

        public void DoAnalyze(string b, string c)
        {
            if(Convert.ToInt32(b) == 9 || Convert.ToInt32(c) == 9)
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
