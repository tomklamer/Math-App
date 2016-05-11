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
        public string title = "Aftrekken analogie";

        public void DoAnalyze(string b, string c)
        {

            char[] listB = b.ToCharArray();
            char[] listC = c.ToCharArray();
            bool tempB = false;
            bool tempC = false;

            if(b.Length == c.Length)
            {
                for (int i = 0; i < listB.Length; i++)
                {
                    if (i != 0)
                    {
                        if (listB[i].ToString() == "0")
                        {
                            tempB = true;
                        }
                        else
                        {
                            tempB = false;
                            break;
                        }

                        if (listC[i].ToString() == "0")
                        {
                            tempC = true;
                        }
                        else
                        {
                            tempC = false;
                            break;
                        }
                    }
                }
                if ((tempB && tempC) && b.Length + c.Length != 2)
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
