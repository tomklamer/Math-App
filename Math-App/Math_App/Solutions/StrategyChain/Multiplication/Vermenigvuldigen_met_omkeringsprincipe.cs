using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain.Multiplication
{
    class Vermenigvuldigen_met_omkeringsprincipe : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 2;
        public string title = "Vermenigvuldigen met omkeringsprincipe";

        public void DoAnalyze(string b, string c)
        {
            if(Convert.ToInt32(b) < 10 && Convert.ToInt32(c) < 10)
            {
                if(Convert.ToInt32(b) > Convert.ToInt32(c))
                {
                    this.use = true;
                }
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
