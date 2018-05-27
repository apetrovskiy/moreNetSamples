namespace ChainOfResponsibilityPattern.Tests
{
    using System.Collections.Generic;
    using System.IO;
    using ObjectModel;
    using Types;

    public class FakeReader: DataFileReader

    {
        public List<TradeItem> TradeItems { get; set; }

        public FakeReader(string fullFilePath, bool isRealFile = true) : base(fullFilePath, isRealFile)
        {

        }
    
        public override IEnumerable<TradeItem> LoadFromFile()
        {
            ///return new List<TradeItem>(new []{new TradeItem{Id = 9, Price = 100, Name = "fake", Amount = 3} });
            /// 
            return TradeItems;
        }


    }
}