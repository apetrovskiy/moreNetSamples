namespace ReportingSample.ObjectModel
{
    using System;
    using System.Collections.Generic;

    public class TestSuite : ITestItem
    {
        public TestSuite(string name = null)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Tags = new List<string>();
            TestScenarios = new List<TestScenario>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Tags { get; set; }
        public List<TestScenario> TestScenarios { get; set; }
    }
}