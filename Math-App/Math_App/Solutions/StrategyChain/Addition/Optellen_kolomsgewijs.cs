using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain
{
    public class Optellen_kolomsgewijs : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 5;
        public string title = "Optellen kolomsgewijs";

        public void DoAnalyze(string b, string c)
        {
            if (b.Length >= 3 && c.Length >= 3)
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
