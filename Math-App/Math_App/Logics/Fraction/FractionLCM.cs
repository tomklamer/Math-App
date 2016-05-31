using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class FractionLCM
	{
		public static int GetLeastCommonMultiple(float a, float b)
		{

			int smaller, bigger;

			if (a > b)
			{
				bigger = Convert.ToInt32(a);
				smaller = Convert.ToInt32(b);
			}
			else
			{
				smaller = Convert.ToInt32(a);
				bigger = Convert.ToInt32(b);
			}

			for (int i = 1; i <= smaller; i++)
			{
				if ((i * bigger) % smaller == 0)
				{
					return i * bigger;
				}
			}
			return smaller * bigger;

		}
	}
}
