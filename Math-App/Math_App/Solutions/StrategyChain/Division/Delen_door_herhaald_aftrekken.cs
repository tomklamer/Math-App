using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain.Division
{
    class Delen_door_herhaald_aftrekken : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 3;
        public string title = "Delen door herhaald aftrekken (met rest)";

        public void DoAnalyze(string b, string c)
        {
            if (Convert.ToInt32(c) < 10 && Convert.ToInt32(b) > Convert.ToInt32(c) &&
                Convert.ToInt32(b) % Convert.ToInt32(c) != 0)
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

