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

            resultCollection.AddRange(reader.LoadTradesFromJson(CombinePath("data001.json")));
            resultCollection.AddRange(reader.LoadTradesFromXml(CombinePath("data002.xml")));
            resultCollection.AddRange(reader.LoadTradesFromCsv(CombinePath("data003.csv")));
            resultCollection.AddRange(reader.LoadTradesFromTsv(CombinePath("data004.tsv")));

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
