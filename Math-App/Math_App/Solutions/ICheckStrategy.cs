using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions
{
    public interface ICheckStrategy
    {
        void setNextChain(ICheckStrategy nextChain);
        bool CheckStrat();
        string ReturnStrat();
    }
}
