using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Xml
{
    public class StrategyXmlObject
    {
        public string Title { get; set; }

        public LevelsXmlObject Level1 { get; set; }

        public LevelsXmlObject Level2 { get; set; }

        public LevelsXmlObject Level3 { get; set; }

        public LevelsXmlObject Level4 { get; set; }

        public LevelsXmlObject Level5 { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }

    public class LevelsXmlObject
    {
        public string image { get; set; }

        public string text { get; set; }

        public string title { get; set; }
    }
}
