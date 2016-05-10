using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CToets
{
    static class  CalculationUtil
    {
        public static int Plus(int a, int b)
        {
            int total = a + b;  
            return total;
        }

        public static int Min(int a, int b)
        {
            int total = a - b;
            return total;
        }

        public static int Maal(int a, int b)
        {
            int total = a * b;
            return total;
        }
        
        public static int Delen(int a, int b)
        {
            int total = a / b;
            return total;
        }
    }
}