namespace ChainOfResponsibilityPattern.ObjectModel
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Types;

    public class TsvReader : DataFileReader
    {
      
        public override IEnumerable<TradeItem> LoadFromFile()
        {
           return ProcessLines(LoadLines());
        }

        IEnumerable<string> LoadLines()
        {
            return File.ReadAllLines(FullFilePath).ToList();
        }

        internal IEnumerable<TradeItem> ProcessLines(IEnumerable<string> lines)
        {
            var result = new List<TradeItem>();
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

        public TsvReader(string fullFilePath, bool isRealFile = true) : base(fullFilePath, isRealFile)
        {
        }
    }
}