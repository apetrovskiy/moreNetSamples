namespace ChainOfResponsibilityPattern.ObjectModel
{
    using System.Collections.Generic;
    using Types;

    public class DataLoader
    {
        public IEnumerable<TradeItem> LoadTrades<TDataFileReader>(TDataFileReader reader)
            where TDataFileReader : DataFileReader
        { 
            return reader.LoadFromFile();
        }
    }
}