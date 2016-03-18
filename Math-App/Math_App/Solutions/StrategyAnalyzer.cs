using System;
using System.Collections.Generic;
using System.Text;
using Math_App.Models.Strategies;
using Math_App.Solutions.StrategyChain;

namespace Math_App.Solutions
{
    public interface StrategyAnalyzer
    {
        List<Strategy> GetStrategies();
    }

    public class MinusAnalyezer : StrategyAnalyzer
    {
        public List<Strategy> GetStrategies()
        {
            List<Strategy> list = new List<Strategy>();



            return list;
        }
    }

    public class MultiplyAnalyezer : StrategyAnalyzer
    {
        public List<Strategy> GetStrategies()
        {
            List<Strategy> list = new List<Strategy>();

            return list;
        }
    }

    public class DevideAnalyezer : StrategyAnalyzer
    {
        public List<Strategy> GetStrategies()
        {
            List<Strategy> list = new List<Strategy>();

            return list;
        }
    }

    public class AdditionAnalyezer : StrategyAnalyzer
    {
        public List<Strategy> GetStrategies()
        {
            List<Strategy> list = new List<Strategy>();

            return list;
        }
    }

    public class FractionAnalyezer : StrategyAnalyzer
    {
        public List<Strategy> GetStrategies()
        {
            List<Strategy> list = new List<Strategy>();

            return list;
        }
    }
}
