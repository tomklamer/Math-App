using System;
using System.Collections.Generic;
using System.Text;
using Math_App.Strategies;

namespace Math_App.NewFolder
{
    public interface ISolutions
    {
        List<Solutions> getSolutions();
        void addSolution(Solutions s);
    }

    public class Multiply : ISolutions
    {
        private List<Solutions> solution = new List<Solutions>();

        public List<Solutions> getSolutions()
        {
            return this.solution;
        }

        public void addSolution(Solutions s)
        {
            this.solution.Add(s);
        }
    }

    public class Devide : ISolutions
    {
        private List<Solutions> solution = new List<Solutions>();

        public List<Solutions> getSolutions()
        {
            return this.solution;
        }

        public void addSolution(Solutions s)
        {
            this.solution.Add(s);
        }
    }

    public class Minus : ISolutions
    {
        private List<Solutions> solution = new List<Solutions>();

        public List<Solutions> getSolutions()
        {
            return this.solution;
        }

        public void addSolution(Solutions s)
        {
            this.solution.Add(s);
        }
    }

    public class Fracture : ISolutions
    {
        private List<Solutions> solution = new List<Solutions>();

        public List<Solutions> getSolutions()
        {
            return this.solution;
        }

        public void addSolution(Solutions s)
        {
            this.solution.Add(s);
        }
    }
}

}
