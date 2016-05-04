using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain.Multiplication
{
    public class Vermenigvuldigen_door_halveren : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 1;
        public string title = "Vermenigvuldigen door halveren";

        public void DoAnalyze(string b, string c)
        {
            this.use = true;

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

