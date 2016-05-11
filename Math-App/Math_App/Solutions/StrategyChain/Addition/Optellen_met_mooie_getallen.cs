using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain
{
    public class Rekenen_met_mooie_getallen : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 6;
        public string title = "Rekenen_met_mooie_getallen";

        public void DoAnalyze(string b, string c)
        {
            if ((Convert.ToInt32(b) + Convert.ToInt32(c) == 50 || Convert.ToInt32(b) + Convert.ToInt32(c) ==  100) && 
                (b[b.Length-1].ToString() == "5" && c[c.Length-1].ToString() == "5"))
            {                
                this.use = true;
            }

            //char[] listB = b.ToCharArray();
            //char[] listC = c.ToCharArray();
            //Array.Reverse(listB);
            //Array.Reverse(listC);
            //int ListCount;

            //int A;
            //int B;

            //if (listB.Length < listC.Length)
            //{
            //    ListCount = listB.Length;
            //}
            //else
            //{
            //    ListCount = listC.Length;
            //}

            //for (int i = 0; i < ListCount; i++)
            //{
            //    // Char.GetNumericValue returns value of type double
            //    A = (int)Char.GetNumericValue(listB[i]);
            //    B = (int)Char.GetNumericValue(listC[i]);

            //    A = Convert.ToInt32(Char.GetNumericValue(listB[i]));
            //    B = Convert.ToInt32(Char.GetNumericValue(listC[i]));

            //    if ((A + B) == 10  && A == 5)
            //    {
            //        this.use = true;
            //    }
            //}

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
