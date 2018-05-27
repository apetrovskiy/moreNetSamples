using System;

namespace CodingTask01
{
	class Program
	{
		/*
         * Complete the function below.
         * DO NOT MODIFY CODE OUTSIDE THIS FUNCTION!
         */
		internal static int[] rearrange(int[] elements)
		{
			if (null == elements || !System.Linq.Enumerable.Any(elements)) return new int[] { };
			var extentsOfTwo = new[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824 };
			var dict = new System.Collections.Generic.Dictionary<int, int>();

			System.Linq.Enumerable.ToList(elements)
				.ForEach(
					element =>
					{
						if (!System.Linq.Enumerable.Contains(dict.Keys, element))
						{
							int numberOfOnes = 0;

							foreach (var extentOfTwo in extentsOfTwo)
								numberOfOnes += 0 < (element & extentOfTwo) ? 1 : 0;

							dict.Add(element, numberOfOnes);
						}
					});

			var valuesPrepared = System.Linq.Enumerable.Select(dict.Keys, key => new { Key = key, Value = dict[key] });
			var valuesSortedByNumberOfOnes = System.Linq.Enumerable.OrderBy(valuesPrepared, item => item.Value);
			var elementsSortedByNumberOfOnesAndNumbers = System.Linq.Enumerable.ThenBy(valuesSortedByNumberOfOnes, item => item.Key);
			var resultList = System.Linq.Enumerable.Select(elementsSortedByNumberOfOnesAndNumbers, item => item.Key);
			var resultArray = System.Linq.Enumerable.ToArray(resultList);

			return resultArray;
		}
		// DO NOT MODIFY CODE OUTSIDE THE ABOVE FUNCTION!

		static void Main(String[] args)
		{
			int[] res;

			int _elements_size = 0;
			_elements_size = Convert.ToInt32(Console.ReadLine());
			int[] _elements = new int[_elements_size];
			int _elements_item;
			for (int _elements_i = 0; _elements_i < _elements_size; _elements_i++)
			{
				_elements_item = Convert.ToInt32(Console.ReadLine());
				_elements[_elements_i] = _elements_item;
			}



			res = rearrange(_elements);
			for (int res_i = 0; res_i < res.Length; res_i++)
			{
				Console.WriteLine(res[res_i]);
			}
		}
	}
}
