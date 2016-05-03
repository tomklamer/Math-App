﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain
{
    public class Splitstrategie : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 2;
        public string title = "Splitstrategie";

        public void DoAnalyze(string b, string c)
        {
            char[] listB = b.ToCharArray();
            char[] listC = c.ToCharArray();
            Array.Reverse(listB);
            Array.Reverse(listC);
            int ListCount;

            int A;
            int B;

            if (listB.Length < listC.Length)
            {
                ListCount = listB.Length;
            }
            else
            {
                ListCount = listC.Length;
            }

            for(int i = 0; i < ListCount; i ++)
            {
                // Char.GetNumericValue returns value of type double
                A = (int)Char.GetNumericValue(listB[i]);
                B = (int)Char.GetNumericValue(listC[i]);

                A = Convert.ToInt32(Char.GetNumericValue(listB[i]));
                B = Convert.ToInt32(Char.GetNumericValue(listC[i]));

                if (A + B < 10)
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