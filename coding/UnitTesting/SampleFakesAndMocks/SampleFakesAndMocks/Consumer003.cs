namespace SampleFakesAndMocks
{
	using System.Collections.Generic;
	using System.Linq;
	using SomeoneElsesComponent;

	public class Consumer003
	{
		public IEnumerable<DataItem> LoadAllTheData()
		{
			var allDataLoader = new DamnBigComponent();
			var dataFromFile = allDataLoader.LoadFileContent(@".\sourceData.txt");
			var dataFromService = allDataLoader.GetDataFromService("http://service.url");
			var result = dataFromService.ToList();
			result.Add(new DataItem { Id = 1000000000, Data = dataFromFile, ItemName = "from file", IsReady = true });
			return result;
		}
	}
}