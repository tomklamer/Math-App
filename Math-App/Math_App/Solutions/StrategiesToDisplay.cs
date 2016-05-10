using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions
{
    public class StrategiesToDisplay
    {
        DataStrategies data = new DataStrategies();

        public List<ICheckStrategy> GetStratsToDisplay(List<ICheckStrategy> a, int b)
        {
            List<int> tempList = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                tempList.Add(a[i].ReturnImportance());
            }

            List<int> stratsImp = data.ReturnStrats(b, tempList);
            List<ICheckStrategy> finalList = new List<ICheckStrategy>();
            if(stratsImp != null)
            {
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
            else
            {
                return null;
            }
        }
    }       
}
