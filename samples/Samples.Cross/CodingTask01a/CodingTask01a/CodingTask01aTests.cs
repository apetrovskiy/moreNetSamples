namespace CodingTask01
{
	using NUnit.Framework;

	public class CodingTask01aTests
	{
		[TestCase(new[] { 3, 1, 2, 3 }, ExpectedResult = new[] { 1, 2, 3 })]
		[TestCase(new[] { 5, 3, 7, 10, 14 }, ExpectedResult = new[] { 3, 5, 10, 7, 14 })]
		[TestCase(new[] { 5, 3, 7, 1000000000, 14 }, ExpectedResult = new[] { 3, 5, 7, 14, 1000000000 })]
		[TestCase(new[] { 5, 3, 7, 1000000000, 14, 999999999, 1000000001 }, ExpectedResult = new[] { 3, 5, 7, 14, 1000000000, 1000000001, 999999999 })]
		public int[] ShouldProcessArray(object source)
		{
			return Program.rearrange((int[])source);
		}
	}
}