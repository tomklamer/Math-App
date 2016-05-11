using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain.Multiplication
{
    public class Vermenigvuldigen_naar_analogie_met_nullen : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 10;
        public string title = "Vermenigvuldigen naar analogie met nullen";

        public void DoAnalyze(string b, string c)
        {
            char[] listB = b.ToCharArray();
            char[] listC = c.ToCharArray();
            bool tempB = false;
            bool tempC = false;

            for(int i = 0; i < listB.Length; i++)
            {
                if(i != 0)
                {
                    if (listB[i] == '0')
                    {
                        tempB = true;
                    }
                    else
                    {
                        tempB = false;
                        break;
                    }
                }
            }

            for (int i = 0; i < listC.Length; i++)
            {
                if (i != 0)
                {
                    if (listC[i] == '0')
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

            if((tempB || tempC) &&  b.Length + c.Length != 2)
            {
                this.use = true;
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

