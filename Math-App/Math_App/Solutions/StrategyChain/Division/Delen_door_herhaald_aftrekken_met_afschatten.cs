using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain.Division
{
    class Delen_door_herhaald_aftrekken_met_afschatten : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 4;
        public string title = "Delen door herhaald aftrekken met afschatten";

        public void DoAnalyze(string b, string c)
        {
            if(Convert.ToInt32(b) > 99 && c.Length < b.Length)
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

