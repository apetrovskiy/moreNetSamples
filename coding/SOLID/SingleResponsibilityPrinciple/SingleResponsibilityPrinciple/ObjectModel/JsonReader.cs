using System.Linq;

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

        internal JsonReader()
        {

        }

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
    }
}