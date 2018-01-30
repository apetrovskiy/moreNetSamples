namespace SingleResponsibilityPrinciple.ObjectModel
{
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using Types;

    public class JsonReader: DataFileReader
    {
        public override IEnumerable<TradeItem> LoadFromFile(string fullFilePath)
        {
            CheckInputFile(fullFilePath);
            var stringData = File.ReadAllText(fullFilePath);
            var result = JsonConvert.DeserializeObject<IEnumerable<TradeItem>>(stringData);

            return result;
        }
    }
}