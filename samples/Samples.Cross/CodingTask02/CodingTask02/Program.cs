using System;

namespace CodingTask02
{
	class Program
	{
		/*
         * Complete the function below.
         * DO NOT MODIFY CODE OUTSIDE THIS FUNCTION!
         */
		internal static string[] twins(string[] a, string[] b)
		{
			const string Yes = "Yes";
			const string No = "No";
			var resultArray = new string[a.Length];
			for (var i = 0; i < a.Length; i++)
			{
				var elementFromFirstArray = a[i];
				var elementFromSecondArray = b[i];

				if (elementFromFirstArray.Length != elementFromSecondArray.Length)
				{
					resultArray[i] = No;
					continue;
				}

				if (elementFromFirstArray == elementFromSecondArray)
				{
					resultArray[i] = Yes;
					continue;
				}

				var firstEvenElements = new System.Collections.Generic.List<char>();
				var secondEvenElements = new System.Collections.Generic.List<char>();
				var firstOddElements = new System.Collections.Generic.List<char>();
				var secondOddElements = new System.Collections.Generic.List<char>();
				for (var j = 0; j < elementFromFirstArray.Length; j += 2)
				{
					firstEvenElements.Add(elementFromFirstArray[j]);
					secondEvenElements.Add(elementFromSecondArray[j]);
					if (j + 1 < elementFromFirstArray.Length)
					{
						firstOddElements.Add(elementFromFirstArray[j + 1]);
						secondOddElements.Add(elementFromSecondArray[j + 1]);
					}
				}
				firstEvenElements.Sort();
				secondEvenElements.Sort();
				firstOddElements.Sort();
				secondOddElements.Sort();
				if (0 == string.Compare(new string(firstEvenElements.ToArray()), new string(secondEvenElements.ToArray())) &&
					0 == string.Compare(new string(firstOddElements.ToArray()), new string(secondOddElements.ToArray())))
				{
					resultArray[i] = Yes;
					continue;
				}

				resultArray[i] = No;
			}

			return resultArray;

		}
		// DO NOT MODIFY CODE OUTSIDE THE ABOVE FUNCTION!

		static void Main(String[] args)
		{
			string[] res;

			int _a_size = 0;
			_a_size = Convert.ToInt32(Console.ReadLine());
			string[] _a = new string[_a_size];
			string _a_item;
			for (int _a_i = 0; _a_i < _a_size; _a_i++)
			{
				_a_item = Console.ReadLine();
				_a[_a_i] = _a_item;
			}


			int _b_size = 0;
			_b_size = Convert.ToInt32(Console.ReadLine());
			string[] _b = new string[_b_size];
			string _b_item;
			for (int _b_i = 0; _b_i < _b_size; _b_i++)
			{
				_b_item = Console.ReadLine();
				_b[_b_i] = _b_item;
			}

			res = twins(_a, _b);
			for (int res_i = 0; res_i < res.Length; res_i++)
			{
				Console.WriteLine(res[res_i]);
			}
		}
	}
}
