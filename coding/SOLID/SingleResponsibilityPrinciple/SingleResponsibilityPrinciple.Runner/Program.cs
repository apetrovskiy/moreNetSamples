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
		    var reader = new DataLoader();
            var resultCollection = new List<TradeItem>();
            Console.WriteLine(System.Environment.CurrentDirectory);

            resultCollection.AddRange(reader.LoadTrades(new TsvReader(CombinePath("data004.tsv"))));
            resultCollection.AddRange(reader.LoadTrades(new JsonReader(CombinePath("data001.json"))));
            resultCollection.AddRange(reader.LoadTrades(new XmlReader(CombinePath("data002.xml"))));
            resultCollection.AddRange(reader.LoadTrades(new CsvReader(CombinePath("data003.csv"))));

            Console.WriteLine(resultCollection.Count);
            resultCollection.ForEach(item => Console.WriteLine(item.Name));
            Console.ReadKey();
        }

        private static string CombinePath(string fileName)
        {
            return Path.Combine(Environment.CurrentDirectory, @"Resources", fileName);
        }
    }
}
