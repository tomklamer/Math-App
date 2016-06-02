using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain
{
    public class Analogie : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 1;
        public string title = "Optellen naar analogie";

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

            if (nextInChain != null)
            {
                nextInChain.DoAnalyze(b, c);
            }

            //if (d != null)
            //{
            //    bool tempBool = false;
            //    for (int i = 0; i < d.Count; i++)
            //    {
            //        if (d[i] == importance)
            //        {
            //            tempBool = true;
            //        }
            //    };
            //    if (!tempBool)
            //    {
            //        this.use = false;
            //    }
            //    if (this.nextInChain != null)
            //    {
            //        nextInChain.DoAnalyze(b, c, d);
            //    }
            //}
            //else
            //{
            //    if (!this.use)
            //    {
            //        if(nextInChain != null)
            //        {
            //            nextInChain.DoAnalyze(b, c);
            //        }
            //    }
            //    else
            //    {
            //        nextInChain.DoAnalyze(b, c, DataStrategies.ReturnStratsToAnalyse(importance));
            //    }
            //}
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
