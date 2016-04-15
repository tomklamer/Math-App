using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions
{
    public static class DataStrategies
    {
        private static List<int> Analogie = new List<int>()
        {
            3            
        };

        public static List<int> Optellen_kolomsgewijs = new List<int>()
        {

        };

        private static List<int> Optellen_met_reigen = new List<int>()
        {
            2,
            5
        };

        private static List<int> Optellen_met_mooie_getallen = new List<int>()
        {
            3,
            4,
            2
        };

        private static List<int> Optellen_met_een_rond_getal = new List<int>()
        {
            2,
            3
        };

        private static List<int> splitsstrategie = new List<int>()
        {
            3
        };

        public static List<int> ReturnStratsToAnalyse(int value)
        {
            switch (value)
            {
                case 1:
                    return Analogie;
                case 2:
                    return splitsstrategie;
                case 3:
                    return Optellen_met_reigen;
                case 4:
                    return Optellen_met_een_rond_getal;
                case 5:
                    return Optellen_kolomsgewijs;
                case 6:
                    return Optellen_met_mooie_getallen;
            }
            return Analogie;
        }
    }
}
