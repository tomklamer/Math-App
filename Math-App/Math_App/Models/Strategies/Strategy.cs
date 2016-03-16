using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Models.Strategies
{
    public class Strategy
    {
        private StrategyInfo info;

        private Level1 level1;
        private Level2 level2;
        private Level3 level3;
        private Level4 level4;
        private Level5 level5;

        public Strategy(StrategyInfo info)
        {
            // fill levelssss
        }

        public Levels GetLevel1()
        {
            return this.level1;
        }

        public Levels GetLevel2()
        {
            return this.level2;
        }

        public Levels GetLevel3()
        {
            return this.level3;
        }

        public Levels GetLevel4()
        {
            return this.level4;
        }

        public Levels GetLevel5()
        {
            return this.level5;
        }
    }
}
