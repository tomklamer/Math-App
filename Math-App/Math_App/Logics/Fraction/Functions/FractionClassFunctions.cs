using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App.Logics
{
	public static class FractionClassFunctions
	{
		public static int getNumberCountInString(string input)
		{
			int amountOfNumbers = 0;
			for(int i = 0; i < input.Length; i++)
			{
				if (CharCheck.isPartOfDigit(input[i].ToString())){
					amountOfNumbers++;
					while (CharCheck.isPartOfDigit(input[i].ToString())){
						i++;
					}
				}
			}
			return amountOfNumbers;
		}

		public static void convertTwoDigitString(ref float numerator, ref float denominator, string input)
		{
			int numberCount = 0;
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < input.Length; i++)
			{
				if (CharCheck.isPartOfDigit(input[i].ToString()))
				{
					numberCount++;
					while (CharCheck.isPartOfDigit(input[i].ToString()))
					{
						sb.Append(input[i]);
						i++;
					}
				}
				switch (numberCount)
				{
					case 1:
						numerator = Convert.ToSingle(sb.ToString());
						break;
					case 2:
						denominator = Convert.ToSingle(sb.ToString());
						break;

				}
				sb.Clear();
			}

		}

		public static void convertThreeDigitString(ref float numerator, ref float denominator, string input)
		{
			int numberCount = 0;
			float wholes = 0;

			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < input.Length; i++)
			{
				if (CharCheck.isDigit(input[i]))
				{
					numberCount++;
					while (CharCheck.isDigit(input[i]))
					{
						sb.Append(input[i]);
						i++;
					}
				}
				switch (numberCount)
				{
					case 1:
						wholes = Convert.ToSingle(sb.ToString());
						break;
					case 2:
						numerator = Convert.ToSingle(sb.ToString());
						break;
					case 3:
						denominator = Convert.ToSingle(sb.ToString());
						break;
					default:
						break;

				}
				sb.Clear();
			}
			numerator = numerator + wholes * denominator;
		}



	}
}
