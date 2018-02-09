namespace SomeoneElsesComponent
{
	using System.Collections.Generic;
	using System.IO;

	public class DamnBigComponent
    {
	    public string LoadFileContent(string filePath)
	    {
		    return File.ReadAllText(filePath);
	    }

	    public IEnumerable<DataItem> GetDataFromService(string serviceUrl)
	    {
		    return new List<DataItem>(new[]
		    {
			    new DataItem
			    {
				    Id = 500000,
				    Data = @"sadf
asdf
asdf
asdf
",
				    IsReady = true,
				    ItemName = "item 0001"
			    },
			    new DataItem {Id = 123456789, Data = string.Empty, IsReady = false, ItemName = "item 0002"},
		    });
	    }
    }
}
