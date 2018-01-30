﻿namespace SingleResponsibilityPrinciple.ObjectModel
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Types;

    public class TsvReader: DataFileReader
    {
        public override IEnumerable<TradeItem> LoadFromFile(string fullFilePath)
    {
        CheckInputFile(fullFilePath);
        var result = new List<TradeItem>();

        using (var reader = new StreamReader(fullFilePath))
        {
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine().Split('\t');
                result.Add(new TradeItem
                {
                    Id = Convert.ToInt32(line[0]),
                    Name = line[1],
                    Price = Convert.ToDecimal(line[2]),
                    Amount = Convert.ToDecimal(line[3])
                });
            }
        }

        return result;
    }
    }
}