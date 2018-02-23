namespace TestInterfaces
{
	using System.Collections.Generic;

	public class TestCase : ITestItem, ITestCase
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}

	public class TestSuite : ITestItem, ITestSuite
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public List<ITestItem> TestItems { get; set; }

		public TestSuite()
		{
			TestItems = new List<ITestItem>();
		}
	}

	public class Requirement : ITestItem, IRequirement
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}

	public class TestObjective : ITestItem, ITestObjective
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}

	public interface ITestObjective
	{
	}

	public interface IRequirement
	{
	}

	public interface ITestSuite
	{
		List<ITestItem> TestItems { get; set; }
	}

	public interface ITestCase
	{
	}

	public interface ITestItem
	{
		long Id { get; set; }
		string Name { get; set; }
		string Description { get; set; }
	}
}