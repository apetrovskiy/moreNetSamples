namespace ReportingSample.ObjectModel
{
    using System.Collections.Generic;

    public interface ITestItem
    {
        int Id { get; set; }
        string Name { get; set; }
        List<string> Tags { get; set; }
    }
}