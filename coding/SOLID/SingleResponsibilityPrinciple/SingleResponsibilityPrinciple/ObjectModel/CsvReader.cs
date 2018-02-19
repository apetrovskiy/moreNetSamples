using System.Linq;

namespace SingleResponsibilityPrinciple.ObjectModel
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Types;

    public class CsvReader : DataFileReader
    {
     
        IEnumerable<string> LoadLines()
        {
            return File.ReadAllLines(FullFilePath).ToList();
        }

        public override IEnumerable<TradeItem> LoadFromFile()
        {
            return ProcessLines(LoadLines());
        }


        internal IEnumerable<TradeItem> ProcessLines(IEnumerable<string> lines)
        {
            var result = new List<TradeItem>();

            lines.Skip(1).ToList().ForEach(line =>
            {
                var id = Convert.ToInt32(line.Substring(0, line.IndexOf(",")));
                line = line.Substring(line.IndexOf(",") + 1);
                var name = line.Substring(0, line.IndexOf(","));
                line = line.Substring(line.IndexOf(",") + 1);
                var price = Convert.ToDecimal(line.Substring(0, line.IndexOf(",")));
                line = line.Substring(line.IndexOf(",") + 1);
                var amount = Convert.ToDecimal(line);

                result.Add(new TradeItem { Id = id, Name = name, Price = price, Amount = amount });
            });

            return result;
        }

        public CsvReader(string fullFilePath, bool isRealFile = true) : base(fullFilePath, isRealFile)
        {
        }
    }
}