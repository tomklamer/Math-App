using System;
using System.Collections.Generic;
using System.Text;
using Math_App.Models.Strategies;

namespace Math_App.NewFolder
{
    public interface ISolutions
    {
        List<Strategy> getSolutions();
    }

    // Strategies for Multiplication
    public class Multiply : ISolutions
    {
        private List<Strategy> Strategy = new List<Strategy>();

        public List<Strategy> getSolutions()
        {
            return this.Strategy;
        }
    }

    // Strategies for Deviding
    public class Devide : ISolutions
    {
        private List<Strategy> Strategy = new List<Strategy>();

        public List<Strategy> getSolutions()
        {
            return this.Strategy;
        }
    }

    // Strategies for Minus
    public class Minus : ISolutions
    {
        private List<Strategy> Strategy = new List<Strategy>();

        public List<Strategy> getSolutions()
        {
            return this.Strategy;
        }
    }

    // Strategies for Fractures
    public class Fracture : ISolutions
    {
        private List<Strategy> Strategy = new List<Strategy>();

        public List<Strategy> getSolutions()
        {
            return this.Strategy;
        }
    }
}

