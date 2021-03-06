﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions.StrategyChain.Multiplication
{
    public class Vermenigvuldigen_met_rond_getal : ICheckStrategy
    {
        private ICheckStrategy nextInChain;
        private bool use = false;
        private int importance = 9;
        public string title = "Vermenigvuldigen met rond getal";

        public void DoAnalyze(string b, string c)
        {
            if((Convert.ToInt32(b) == 49 || Convert.ToInt32(b) == 99)
                || (Convert.ToInt32(c) == 49 || Convert.ToInt32(c) == 99))
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

