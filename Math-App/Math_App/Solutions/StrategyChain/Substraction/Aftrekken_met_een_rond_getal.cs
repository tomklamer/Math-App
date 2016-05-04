using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain.Substraction
{
    public class Rekenen_met_een_rond_getal : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 3;
        public string title = "Rekenen met enn rond getal";

        public void DoAnalyze(string b, string c)
        {
            var arrayB = b.ToCharArray();
            var arrayC = c.ToCharArray();
            Array.Reverse(arrayB);
            Array.Reverse(arrayC);
            int ListCount = 0;

            if (arrayB.Length < arrayC.Length)
            {
                ListCount = arrayB.Length;
            }
            else
            {
                ListCount = arrayC.Length;
            }

            for (int i = 0; i < ListCount; i++)
            {
                if (i != 0)
                {
                    if ((Convert.ToInt32(arrayC[i]) == 9 && Convert.ToInt32(arrayB[i]) >= 1) ||
                        (Convert.ToInt32(arrayC[i]) == 8 && Convert.ToInt32(arrayB[i]) >= 2))
                    {
                        this.use = true;
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