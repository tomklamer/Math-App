using System;
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

        public void DoAnalyze(string b, string c, List<int> d)
        {
            char[] listB = b.ToCharArray();
            char[] listC = c.ToCharArray();
            Array.Reverse(listB);
            Array.Reverse(listC);
            int ListCount;

            if(listB.Length < listC.Length)
            {
                ListCount = listB.Length;
            }
            else
            {
                ListCount = listC.Length;
            }

            for(int i = 0; i < ListCount; i ++)
            {
                if((Convert.ToInt32(listB[i]) + Convert.ToInt32(listC[i])) > 10)
                {
                    this.use = true;
                }
            }

            if (d != null)
            {
                bool tempBool = false;
                for (int i = 0; i < d.Count; i++)
                {
                    if (d[i] == importance)
                    {
                        tempBool = true;
                    }
                };
                if (!tempBool)
                {
                    this.use = false;
                }
                if (this.nextInChain != null)
                {
                    nextInChain.DoAnalyze(b, c, d);
                }
            }
            else
            {
                if (!this.use)
                {
                    if(nextInChain != null)
                    {
                        nextInChain.DoAnalyze(b, c);
                    }
                }
                else
                {
                    nextInChain.DoAnalyze(b, c, DataStrategies.ReturnStratsToAnalyse(importance));
                }
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
