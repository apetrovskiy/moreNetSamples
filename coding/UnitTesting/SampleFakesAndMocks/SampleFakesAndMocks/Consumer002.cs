namespace SampleFakesAndMocks
{
	using System.Collections.Generic;
	using SomeoneElsesComponent;

	public class Consumer002
	{
		public IEnumerable<DataItem> LoadDataFromService(string url)
		{
			var loader = new DamnBigComponent();
			return loader.GetDataFromService(url);
		}
	}
}