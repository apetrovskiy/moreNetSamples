namespace SingleResponsibilityPrinciple.ObjectModel
{
    using System.Collections.Generic;
    using Types;

	public class DataLoader
	{
	
	    public IEnumerable<TradeItem> LoadTradesFromCsv(string filePath)
		{
			return new CsvReader(filePath).LoadFromFile();
		}
        
	    public IEnumerable<TradeItem> LoadTradesFromTsv(string filePath)
	    {
	        return new TsvReader(filePath).LoadFromFile();
	    }

	    public IEnumerable<TradeItem> LoadTradesFromXml(string filePath)
	    {
	        return new XmlReader(filePath).LoadFromFile();
	    }

	    public IEnumerable<TradeItem> LoadTradesFromJson(string fullPathToFile)
	    {
	        return new JsonReader(fullPathToFile).LoadFromFile();
	    }
	}
}