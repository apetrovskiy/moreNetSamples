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
		    var resultCollection = new List<TradeItem>();

            resultCollection.AddRange(ReaderFactory.GetReader(CombinePath("data001.json")).LoadFromFile());
            resultCollection.AddRange(ReaderFactory.GetReader(CombinePath("data002.xml")).LoadFromFile());
            resultCollection.AddRange(ReaderFactory.GetReader(CombinePath("data003.csv")).LoadFromFile());
            resultCollection.AddRange(ReaderFactory.GetReader(CombinePath("data004.tsv")).LoadFromFile());
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
