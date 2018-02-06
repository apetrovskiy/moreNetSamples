namespace SingleResponsibilityPrinciple.ObjectModel
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Types;

    public class TsvReader : DataFileReader
    {
        public TsvReader(string fullFilePath)
        {
            FullFilePath = fullFilePath;
            CheckInputFile(FullFilePath);
        }

        internal TsvReader()
        {
        }

        public override IEnumerable<TradeItem> LoadFromFile()
        {
           return ProcessLines();
        }

        List<string> LoadLines()
        {
            return File.ReadAllLines(FullFilePath).ToList();
        }

        private IEnumerable<TradeItem> ProcessLines()
        {
            var lines = LoadLines();

            //StreamReader reader;
            var result = new List<TradeItem>();
            // var line = reader.ReadLine().Split('\t');
            lines.Skip(1).ToList().ForEach(line =>
            {
                var lineData = line.Split('\t');
                result.Add(new TradeItem
                {
                    Id = Convert.ToInt32(lineData[0]),
                    Name = lineData[1],
                    Price = Convert.ToDecimal(lineData[2]),
                    Amount = Convert.ToDecimal(lineData[3])
                });
            });
            return result;
        }
    }
}