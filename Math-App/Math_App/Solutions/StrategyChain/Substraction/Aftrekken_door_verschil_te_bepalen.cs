using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain.Substraction
{
    public class Aftrekken_door_verschil_te_bepalen : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 1;
        public string title = "Aftrekken door verschil te bepalen";

        public void DoAnalyze(string b, string c)
        {
            int first = Convert.ToInt32(b);
            int second = Convert.ToInt32(c);
            int difference = first - second;
			//this.use = true;
			//if (difference < 10)
   //         {
   //             this.use = true;
   //             //this.importance = ;
   //             //if(difference < 3)
   //             //{
   //             //    this.importance = 4;
   //             //}

   //         }

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
