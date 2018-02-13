namespace SingleResponsibilityPrinciple.ObjectModel
{
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using Types;

    public class JsonReader: DataFileReader
    {
       public override IEnumerable<TradeItem> LoadFromFile()
        {
            return ProcessLines(LoadLines());
        }
        string LoadLines()
        {
            return File.ReadAllText(FullFilePath); ;
        }
        

        public IEnumerable<TradeItem> ProcessLines(string lines)
        {

            var result = JsonConvert.DeserializeObject<IEnumerable<TradeItem>>(lines);

            return result;
        }

        public JsonReader(string fullFilePath, bool isRealFile = true) : base(fullFilePath, isRealFile)
        {
        }
    }
}