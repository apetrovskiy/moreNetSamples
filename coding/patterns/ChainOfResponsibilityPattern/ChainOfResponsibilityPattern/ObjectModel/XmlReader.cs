namespace ChainOfResponsibilityPattern.ObjectModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Types;

    public class XmlReader: DataFileReader
    {
       XDocument LoadLines()
        {
            return XDocument.Load(FullFilePath); 
        }

        public override IEnumerable<TradeItem> LoadFromFile()
        {
            return ProcessLines(LoadLines());
        }

        public IEnumerable<TradeItem> ProcessLines(XDocument  lines)
    {
        // TODO: please use XDocument.Parse
        var root = lines.Root;
        var result = root.Descendants("item").Select(item => new TradeItem
        {
            Id = Convert.ToInt32(item.Element("id").Value),
            Name = item.Element("name").Value,
            Price = Convert.ToDecimal(item.Element("price").Value),
            Amount = Convert.ToDecimal(item.Element("amount").Value)
        });

        return result;
    }

        public XmlReader(string fullFilePath, bool isRealFile = true) : base(fullFilePath, isRealFile)
        {
        }
    }
}