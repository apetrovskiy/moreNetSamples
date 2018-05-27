namespace CodingTask02
{
	using NUnit.Framework;

	public class CodintTask02Tests
	{
		[TestCase(new[] { "cdab", "dcba" }, new[] { "abcd", "abcd" }, ExpectedResult = new[] { "Yes", "No" })]
		[TestCase(new[] { "abcd", "abcd" }, new[] { "abcd", "abcd" }, ExpectedResult = new[] { "Yes", "Yes" })]
		[TestCase(new[] { "cdab", "abcd" }, new[] { "abcd", "abcd" }, ExpectedResult = new[] { "Yes", "Yes" })]
		[TestCase(new[] { "cdba", "dcba" }, new[] { "abcd", "abcd" }, ExpectedResult = new[] { "No", "No" })]
		[TestCase(new[] { "abcdefgh", "zxcvbnmj", "qwerty" }, new[] { "abcdefgh", "zxcvbnmj", "qwerty" }, ExpectedResult = new[] { "Yes", "Yes", "Yes" })]
		[TestCase(new[] { "gbcdafeh", "zxcvbnmj", "eyqwtr" }, new[] { "abcdefgh", "zxcvbnmj", "qwerty" }, ExpectedResult = new[] { "Yes", "Yes", "Yes" })]
		[TestCase(new[] { "gbcdafeh", "zxcvbnmj", "eyqwtr" }, new[] { "abcdefgh", "zxcvbnjm", "qwerty" }, ExpectedResult = new[] { "Yes", "No", "Yes" })]
		[TestCase(new[] { "gbcdafeh", "zxcvbnmj", "eyqwtr" }, new[] { "abcdegfh", "zxcvbnmj", "qwrety" }, ExpectedResult = new[] { "No", "Yes", "No" })]
		[TestCase(new[] { "gbcdafeh", "zxcbvnmj", "etqwyr" }, new[] { "abcedfgh", "zxcvbnmj", "qwerty" }, ExpectedResult = new[] { "No", "No", "No" })]
		[TestCase(new[] { "gbcdafehl", "zxcvbnmjl", "eyqwtrl" }, new[] { "abcdefghl", "zxcvbnmjl", "qwertyl" }, ExpectedResult = new[] { "Yes", "Yes", "Yes" })]
		[TestCase(new[] { "cdab", "dcbag" }, new[] { "abcd", "abcd" }, ExpectedResult = new[] { "Yes", "No" })]
		[TestCase(new[] { "cda", "dcbag" }, new[] { "abcd", "abcd" }, ExpectedResult = new[] { "No", "No" })]
		public string[] ShouldReturnEvaluationOfComparison(object firstArray, object secondArray)
		{
			return Program.twins((string[])firstArray, (string[])secondArray);
		}
	}
}