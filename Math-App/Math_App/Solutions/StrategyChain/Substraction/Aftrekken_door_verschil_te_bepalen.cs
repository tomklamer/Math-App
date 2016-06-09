
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math_App.Solutions.StrategyChain.Substraction
{
    public class Aftrekken_door_verschil_te_bepalen : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 6;
        public string title = "Aftrekken door verschil te bepalen";

        public void DoAnalyze(string b, string c)
        {
            float first = Convert.ToSingle(b);
            float second = Convert.ToSingle(c);
            int ListCount;

            char[] bAr = b.ToCharArray();
            char[] cAr = c.ToCharArray();

            if (bAr.Length < cAr.Length)
            {
                ListCount = bAr.Length;
            }
            else
            {
                ListCount = cAr.Length;
            }

            if (((bAr.Length == 2 || cAr.Length == 2) ||
                (bAr.Length == 2 || cAr.Length == 3) || 
                (bAr.Length == 3 && cAr.Length == 2)) &&
                Math.Abs(first - second) <= 5)
            {
                if (bAr.First() != cAr.First())
                {
                    this.use = true;
                }
            }
            else if((bAr.Length == 3 && cAr.Length == 3) && Math.Abs(first - second) <= 20)
            {
                for (int i = 0; i < ListCount; i++)
                {
                    if (bAr.First() != cAr.First())
                    {
                        this.use = true;
                    }
                }
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
