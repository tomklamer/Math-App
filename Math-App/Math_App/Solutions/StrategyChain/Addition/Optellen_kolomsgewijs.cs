﻿using System;
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
                char[] bAr = b.ToCharArray();
                char[] cAr = c.ToCharArray();
                float x = 0;
                float y = 0;

                for (int i = 0; i < bAr.Length; i++)
                {
                    if (i != 0)
                    {
                        x += Convert.ToSingle(Char.GetNumericValue(bAr[i]));
                    }
                }
                for (int i = 0; i < cAr.Length; i++)
                {
                    if (i != 0)
                    {
                        y += Convert.ToSingle(Char.GetNumericValue(cAr[i]));
                    }
                }

                if (x != 0 && y != 0)
                {
                    this.use = true;
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
