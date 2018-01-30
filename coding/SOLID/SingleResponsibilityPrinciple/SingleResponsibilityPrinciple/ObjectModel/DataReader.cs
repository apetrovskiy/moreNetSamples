namespace SingleResponsibilityPrinciple.ObjectModel
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.IO;
	using System.Linq;
	using System.Runtime.InteropServices;
	using System.Xml.Linq;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using Types;

	public class DataReader
	{
		public IEnumerable<TradeItem> LoadTradesFromCommaSeparatedFile(string filePath)
		{
			var result = new List<TradeItem>();
			var lineCount = 0;

			using (var reader = new StreamReader(filePath))
			{
				while (!reader.EndOfStream)
				{
					var line = reader.ReadLine();
					lineCount++;
					if (lineCount < 2) continue;

					var id = Convert.ToInt32(line.Substring(0, line.IndexOf(",")));
					line = line.Substring(line.IndexOf(",") + 1);
					var name = line.Substring(0, line.IndexOf(","));
					line = line.Substring(line.IndexOf(",") + 1);
					var price = Convert.ToDecimal(line.Substring(0, line.IndexOf(",")));
					line = line.Substring(line.IndexOf(",") + 1);
					var amount = Convert.ToDecimal(line);

					result.Add(new TradeItem {Id = id, Name = name, Price = price, Amount = amount });
				}
			}

			return result;
		}

		public IEnumerable<TradeItem> LoadTradesFromTsv(string filePath)
		{
			

			return new List<TradeItem>();
		}

		public IEnumerable<TradeItem> ProcessXmlWithTrades(string pathToDirectory, string fileName)
		{
			var filePath = Path.Combine(pathToDirectory, fileName);
			if (!File.Exists(filePath))
				throw new FileNotFoundException("Cannot fild file " + filePath);
			var xdoc = XDocument.Load(filePath);
			var root = xdoc.Root;
			var result = root.Descendants("item").Select(item => new TradeItem
			{
				Id = Convert.ToInt32(item.Element("id").Value),
				Name = item.Element("name").Value,
				Price = Convert.ToDecimal(item.Element("price").Value),
				Amount = Convert.ToDecimal(item.Element("amount").Value)
			});

			return result;
		}

		public IEnumerable<TradeItem> LoadDataFromJsonFile(string fullPathToFile)
		{
			var stringData = File.ReadAllText(fullPathToFile);
			var result = JsonConvert.DeserializeObject<IEnumerable<TradeItem>>(stringData);

			return result;
		}
	}
}