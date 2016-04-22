
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

			//// Conditions:
			//	1. Both numbers are two digit numbers
			//	2. Difference between them is up to 4.
			//	3. a1 < b1

			//check if numbers are both two digit numbers
			if(b.Length == 2 && c.Length == 2)
			{
				//check difference
				if (difference <= 4)
				{
					//get digits into variables
					int a1 = first % 10;
					//int a2 = (first - first % 10) / 10;
					int b1 = second % 10;
					//int b2 = (second - second % 10) / 10;

					if (a1 < b1)
					{
						this.use = true;
					}
				}
				//else false
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
