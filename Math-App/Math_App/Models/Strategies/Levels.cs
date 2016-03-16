using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Models.Strategies
{
    public abstract class Levels
    {
        private string image;
        private string title;

        public Levels(string im, string ti)
        {
            this.image = im;
            this.title = ti;
        }

        public string GetImage()
        {
            return this.image;
        }

        public string GetTitle()
        {
            return this.title;
        }
    }

    // level1
    public class Level1 : Levels
    {
        public Level1(string im, string ti) : base(im, ti)
        {
        }
    }

    // level2
    public class Level2 : Levels
    {
        public Level2(string im, string ti) : base(im, ti)
        {
        }
    }

    // level3
    public class Level3 : Levels
    {
        public Level3(string im, string ti) : base(im, ti)
        {
        }
    }

    // level4
    public class Level4 : Levels
    {
        public Level4(string im, string ti) : base(im, ti)
        {
        }
    }

    // level5
    public class Level5 : Levels
    {
        public Level5(string im, string ti) : base(im, ti)
        {
        }
    }
}
