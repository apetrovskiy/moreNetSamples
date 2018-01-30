namespace SingleResponsibilityPrinciple.ObjectModel
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Types;

    public class CsvReader : DataFileReader
    {
        public override IEnumerable<TradeItem> LoadFromFile(string fullFilePath)
        {
            CheckInputFile(fullFilePath);
            var result = new List<TradeItem>();
            var lineCount = 0;

            using (var reader = new StreamReader(fullFilePath))
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

                    result.Add(new TradeItem {Id = id, Name = name, Price = price, Amount = amount});
                }
            }

            return result;
        }
    }
}