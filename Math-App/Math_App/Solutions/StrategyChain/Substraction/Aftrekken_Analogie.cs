using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain.Substraction
{
    public class Aftrekken_Analogie : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 1;
        public string title = "Aftrekken door verschil te bepalen";

        public void DoAnalyze(string b, string c)
        {
            if (b.Length >= 2 && c.Length >= 2 && b.Length == c.Length)
            {
                char[] listB = b.ToCharArray();
                char[] listC = c.ToCharArray();

                for (int i = 1; i < listB.Length; i++)
                {
                    if (listB[i].ToString() == "0" && listC[i].ToString() == "0")
                    {
                        this.use = true;
                    }
                    else
                    {
                        this.use = false;
                        break;
                    }
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
