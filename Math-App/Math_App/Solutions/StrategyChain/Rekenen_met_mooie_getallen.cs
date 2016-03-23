using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain
{
    public class Rekenen_met_mooie_getallen : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 2;
        public string title = "Rekenen_met_mooie_getallen";

        public void DoAnalyze(string b, string c)
        {
            if (b.Length <= 2 && c.Length <= 2)
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
