namespace SingleResponsibilityPrinciple.ObjectModel
{
    using System.Collections.Generic;
    using Types;

	public class DataReader
	{
	    private readonly CsvReader _csvReader = new CsvReader();
	    private readonly TsvReader _tsvReader = new TsvReader();
	    private readonly XmlReader _xmlReader = new XmlReader();
	    private readonly JsonReader _jsonReader = new JsonReader();

	    public IEnumerable<TradeItem> LoadTradesFromCsv(string filePath)
		{
			return _csvReader.LoadFromFile(filePath);
		}
        
	    public IEnumerable<TradeItem> LoadTradesFromTsv(string filePath)
	    {
	        return _tsvReader.LoadFromFile(filePath);
	    }

	    public IEnumerable<TradeItem> LoadTradesFromXml(string filePath)
	    {
	        return _xmlReader.LoadFromFile(filePath);
	    }

	    public IEnumerable<TradeItem> LoadTradesFromJson(string fullPathToFile)
	    {
	        return _jsonReader.LoadFromFile(fullPathToFile);
	    }
	}
}