using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain.Division
{
    class Delen_door_gebruik_van_inverse_relatie : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 1;
        public string title = "Delen door gebruik van inverse relatie";

        public void DoAnalyze(string b, string c)
        {
            if(Convert.ToInt32(c) < 10 && (Convert.ToInt32(b) / Convert.ToInt32(c) == Convert.ToInt32(b)))
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

