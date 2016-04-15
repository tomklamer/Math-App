using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain.Substraction
{
    public class Splitstrategie_substraction : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 4;
        public string title = "Splitstrategie";

        public void DoAnalyze(string b, string c, List<int> d)
        {
			//// Conditions:
			//	1. Both numbers are two digit numbers
			//	2. a1 > b1, a2 > b2

			// condition 1

			if(b.Length == 2 && c.Length == 2)
			{
				//condition 2
				
				int first = Convert.ToInt32(b);
				int second = Convert.ToInt32(c);

				int a1 = first % 10;
				int a2 = ((first - a1) / 10) % 10;

				int b1 = second % 10;
				int b2 = ((second - b1) / 10) % 10;

				if(a1 > b1 &&
					a2 > b2)
				{
					this.use = true;
					this.importance = 1;
				}
			}



			//this.use = true;
           // nextInChain.DoAnalyze(b, c);
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
