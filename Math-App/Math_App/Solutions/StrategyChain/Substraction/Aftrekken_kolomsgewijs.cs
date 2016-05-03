using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain.Substraction
{
    public class Komols_gewijs_aftrekken : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 2;
        public string title = "Koloms gewijs Aftrekken";

        public void DoAnalyze(string b, string c)
        {
            if (b.Length >= 3 && c.Length >= 3)
            {
                char[] bAr = b.ToCharArray();
                char[] cAr = c.ToCharArray();
                int x = 0;
                int y = 0;

                for(int i = 0; i < bAr.Length; i++)
                {
                    if(i != 0)
                    {
                        x += Convert.ToInt32(Char.GetNumericValue(bAr[i]));
                    }
                }
                for (int i = 0; i <cAr.Length; i++)
                {
                    if (i != 0)
                    {
                        y += Convert.ToInt32(Char.GetNumericValue(cAr[i]));
                    }
                }

                if(x != 0 && y != 0)
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
