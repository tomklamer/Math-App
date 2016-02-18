using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.NewFolder
{
    public interface ISolutions
    {
        List<Solution> getSolutions();
        void addSolution(Solution s);
    }

    public class Multiply : ISolutions
    {
        private List<Solution> solutions = new List<Solution>();

        public List<Solution> getSolutions()
        {
            return this.solutions;
        }

        public void addSolution(Solution s)
        {

        }
    }

    public class Devide : ISolutions
    {
        private List<Solution> solutions = new List<Solution>();

        public List<Solution> getSolutions()
        {
            return this.solutions;
        }

        public void addSolution(Solution s)
        {
            this.solutions.Add(s);
        }
    }

    public class Minus : ISolutions
    {
        private List<Solution> solutions = new List<Solution>();

        public List<Solution> getSolutions()
        {
            return this.solutions;
        }

        public void addSolution(Solution s)
        {
            this.solutions.Add(s);
        }
    }

    public class Fracture : ISolutions
    {
        private List<Solution> solutions = new List<Solution>();

        public List<Solution> getSolutions()
        {
            return this.solutions;
        }

        public void addSolution(Solution s)
        {
            this.solutions.Add(s);
        }
    }
}

}
