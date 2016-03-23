using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions
{
    public interface ICheckStrategy
    {
        void DoAnalyze(string a, string b);
        void setNextChain(ICheckStrategy nextChain);
        ICheckStrategy ReturnStrat();
        string ReturnTitle();
        int ReturnImportance();
    }
}
