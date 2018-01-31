namespace SingleResponsibilityPrinciple.ObjectModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Types;

    public class XmlReader: DataFileReader
    {
        public XmlReader(string fullFilePath)
        {
            FullFilePath = fullFilePath;
            CheckInputFile(FullFilePath);
        }

        public override IEnumerable<TradeItem> LoadFromFile()
    {
        var xdoc = XDocument.Load(FullFilePath);
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
    }
}