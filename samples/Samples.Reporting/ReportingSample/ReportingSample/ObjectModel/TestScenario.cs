namespace ReportingSample.ObjectModel
{
    using System;
    using System.Collections.Generic;

    public class TestScenario : ITestItem
    {
        public TestScenario(string name = null)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Tags = new List<string>();
            TestCases = new List<TestCase>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Tags { get; set; }
        public List<TestCase> TestCases { get; set; }
    }
}