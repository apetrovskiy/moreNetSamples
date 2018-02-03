namespace SingleResponsibilityPrinciple.Runner
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using ObjectModel;
	using Types;

	class Program
	{
		static void Main(string[] args)
		{
			var reader = new DataReader();
			var resultCollection = new List<TradeItem>();
			Console.WriteLine(System.Environment.CurrentDirectory);
			
			resultCollection.AddRange(reader.LoadDataFromJsonFile(Path.Combine(Environment.CurrentDirectory, @"Resources\data001.json")));
			resultCollection.AddRange(reader.ProcessXmlWithTrades(Path.Combine(Environment.CurrentDirectory, "Resources"), "data002.xml"));
			resultCollection.AddRange(reader.LoadTradesFromCommaSeparatedFile(Path.Combine(Environment.CurrentDirectory, @"Resources\data003.csv")));
			resultCollection.AddRange(reader.LoadTradesFromTsv(Path.Combine(Environment.CurrentDirectory, @"Resources\data004.tsv")));

			Console.WriteLine(resultCollection.Count);
			Console.ReadKey();
		}
	}
}
