using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain
{
    public class Strategy1 : ICheckStrategy
    {
        private ICheckStrategy nextInChain;

        public Strategy1()
        {

        }

        public bool CheckStrat()
        {

            return false;
        }

        public string ReturnStrat()
        {

            return "";
        }

        public void setNextChain(ICheckStrategy nextChain)
        {
            this.nextInChain = nextChain;
        }
    }
}
