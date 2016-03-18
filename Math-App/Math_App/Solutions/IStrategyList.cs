using System;
using System.Collections.Generic;
using System.Text;
using Math_App.Solutions.StrategyChain;
using Math_App.Models.Strategies;

namespace Math_App.Solutions
{
    public interface IStrategyList
    {
        List<string> getSolutions();
    }

    // Strategies for Multiplication
    public class Multiply : IStrategyList
    {
        ICheckStrategy strat1;
        ICheckStrategy strat2;

        public Multiply()
        {
        }

        public List<string> getSolutions()
        {
            StrategyAnalyzer an = new MultiplyAnalyezer();
            return an.GetStrategies();
        }
    }

    // Strategies for Deviding
    public class Devide : IStrategyList
    {
        ICheckStrategy strat1;
        ICheckStrategy strat2;

        public Devide()
        {
        }

        public List<string> getSolutions()
        {
            StrategyAnalyzer an = new MultiplyAnalyezer();
            return an.GetStrategies();
        }
    }

    // Strategies for Minus
    public class Minus : IStrategyList
    {
        ICheckStrategy strat1;
        ICheckStrategy strat2;

        public Minus()
        {
        }

        public List<string> getSolutions()
        {
            StrategyAnalyzer an = new MultiplyAnalyezer();
            return an.GetStrategies();
        }
    }

    // Strategies for Fractures
    public class Fracture : IStrategyList
    {
        ICheckStrategy strat1;
        ICheckStrategy strat2;

        public Fracture()
        {
        }

        public List<string> getSolutions()
        {
            StrategyAnalyzer an = new MultiplyAnalyezer();
            return an.GetStrategies();
        }
    }

    // Strategies for Addition
    public class Addition : IStrategyList
    {
        ICheckStrategy strat1;
        ICheckStrategy strat2;

        public Addition()
        {
        }

        public List<string> getSolutions()
        {
            StrategyAnalyzer an = new MultiplyAnalyezer();
            return an.GetStrategies();
        }
    }
}

