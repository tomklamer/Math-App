using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain
{
    public class Optellen_met_reigen : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 3;
        public string title = "Optellen met rijgen";

        public void DoAnalyze(string b, string c)
        {
            char[] listB = b.ToCharArray();
            char[] listC = c.ToCharArray();
            Array.Reverse(listB);
            Array.Reverse(listC);
            int ListCount;

            float A;
            float B;

            if (listB.Length < listC.Length)
            {
                ListCount = listB.Length;
            }
            else if (listB.Length == listC.Length)
            {
                ListCount = listB.Length - 1;
            }
            else
            {
                ListCount = listC.Length;
            }

            for (int i = 0; i < ListCount; i++)
            {
                A = (int)Char.GetNumericValue(listB[i]);
                B = (int)Char.GetNumericValue(listC[i]);

                A = Convert.ToSingle(Char.GetNumericValue(listB[i]));
                B = Convert.ToSingle(Char.GetNumericValue(listC[i]));

                if (A + B > 10)
                {
                    this.use = true;
                }
            }

            if(nextInChain != null)
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