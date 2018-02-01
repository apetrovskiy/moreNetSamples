namespace SingleResponsibilityPrinciple.ObjectModel
{
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using Types;

    public class JsonReader: DataFileReader
    {
        public JsonReader(string fullFilePath)
        {
            FullFilePath = fullFilePath;
            CheckInputFile(FullFilePath);
        }

        public override IEnumerable<TradeItem> LoadFromFile()
        {
            var stringData = File.ReadAllText(FullFilePath);
            var result = JsonConvert.DeserializeObject<IEnumerable<TradeItem>>(stringData);

            return result;
        }
    }
}