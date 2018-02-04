namespace ReportingSample.ObjectModel
{
    using System;
    using System.Collections.Generic;

    public class TestCase : ITestItem
    {
        public TestCase(string name = null)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Tags = new List<string>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Tags { get; set; }
    }
}