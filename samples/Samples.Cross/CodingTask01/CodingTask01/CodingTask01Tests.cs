namespace CodingTask01
{
	// using Microsoft.VisualStudio.TestTools.UnitTesting;

	using NUnit.Framework;

	[TestFixture]
	public class CodingTask01Tests
	{
		[TestCase(new[] { 3, 1, 2, 3 }, ExpectedResult = new[] { 1, 2, 3 })]
		[TestCase(new[] { 5, 3, 7, 10, 14 }, ExpectedResult = new[] { 5, 3, 7, 10, 14 })]
		public int[] ShouldProcessArray(int[] source)
		{
			return Program.rearrange(source);
		}

		// [TestMethod]
		[Test]
		public void aaa()
		{
			Assert.True(true);
		}
	}
}