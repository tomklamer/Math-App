using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain.Multiplication
{
    public class Vermenigvulidgen_door_te_verdubbelen : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 11;
        public string title = "Vermenigvuldigen door te verdubbelen";

        public void DoAnalyze(string b, string c)
        {
            if(((Convert.ToInt32(b) % 2 == 0) && (c[c.Length-1] == '5'))
                || ((Convert.ToInt32(c) % 2 == 0) && (b[b.Length-1] == '5')))
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

