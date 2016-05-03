using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions
{
    public class StrategiesToDisplay
    {
        DataStrategies data = new DataStrategies();

        public List<ICheckStrategy> GetStratsToDisplay(List<ICheckStrategy> a)
        {
            List<int> tempList = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                tempList.Add(a[i].ReturnImportance());
            }

            List<int> stratsImp = data.ReturnStrats(1, tempList);
            List<ICheckStrategy> finalList = new List<ICheckStrategy>();
            for (int i = 0; i < stratsImp.Count; i++)
            {
                for (int x = 0; x < a.Count; x++)
                {
                    if (stratsImp[i] == a[x].ReturnImportance())
                    {
                        finalList.Add(a[x]);
                    }
                }
            }
            return finalList;
        }
    }       
}
