namespace SampleFakesAndMocks.Runner
{
	using System;
	using System.Linq;

	class Program
	{
		static void Main(string[] args)
		{
			var ourLoader001 = new Consumer001();
			Console.WriteLine(ourLoader001.UseFileContent(@".\sourceData.txt"));
			PrintLines();

			var ourLoader002 = new Consumer002();
			var collection = ourLoader002.LoadDataFromService("http://service.org");
			collection.ToList().ForEach(item => Console.WriteLine(item.ItemName));
			PrintLines();

			var ourLoader003 = new Consumer003();
			var collection2 = ourLoader003.LoadAllTheData();
			collection2.ToList().ForEach(item => Console.WriteLine(item.ItemName));
			PrintLines();

			Console.ReadKey();
		}

		private static void PrintLines()
		{
			Console.WriteLine("=====================================================================");
		}
	}
}
