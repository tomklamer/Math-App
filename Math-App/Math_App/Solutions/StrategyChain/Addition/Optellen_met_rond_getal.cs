using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain
{
    public class Rekenen_met_rond_getal : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 4;
        public string title = "Rekenen met rond getal";

        public void DoAnalyze(string b, string c)
        {
            var arrayA = b.ToCharArray();
            var arrayB = c.ToCharArray();

            bool temp = false;
            for (int i = 0; i < arrayA.Length; i++)
            {
                if (i != 0)
                {
                    if (arrayA[i].ToString() == "9" ||
                        arrayA[i].ToString() == "6" ||
                        arrayA[i].ToString() == "4" ||
                        arrayA[i].ToString() == "1")
                    {
                        temp = true;
                    }
                }
            }
            for (int i = 0; i < arrayB.Length; i++)
            {
                if (i != 0)
                {
                    if (arrayB[i].ToString() == "9" ||
                        arrayB[i].ToString() == "6" ||
                        arrayB[i].ToString() == "4" ||
                        arrayB[i].ToString() == "1")
                    {
                        temp = true;
                    }
                }
            }

            if (temp) { this.use = true;  }

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
