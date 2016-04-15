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

        public void DoAnalyze(string b, string c, List<int> d)
        {
			// Conditions
			// 1. Both numbers are two digit numbers
			// 2. a2 and b2 are different
			// 3. a1 < b1
			// 4. Preferably b1 is 9, 8, 7 maybe 6 while a1 is 1, 2, 3

			// Condition 1

			if (b.Length == 2 && c.Length == 2)
			{

				int first = Convert.ToInt32(b);
				int second = Convert.ToInt32(c);
				int difference = (first - second) % 10;

				int a1 = first % 10;
				int a2 = ((first - a1) / 10) % 10;

				int b1 = second % 10;
				int b2 = ((second - b1) / 10) % 10;

				// Condition 2 and 3
				if (a2 != b2 && a1 < b1)
				{
					this.use = true;
					// Condition 4
					if(b1 >= 6 && b1 <= 9)
					{
						this.importance = 1;
					}
				}
				else
				{
					//not usable
				}



			}


            this.use = true;
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
