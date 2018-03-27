namespace SingletonPattern
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml.Linq;

    public class ConfigReader
    {
        public Dictionary<string, object> Settings { get; set; }

        public ConfigReader()
        {
            Settings = new Dictionary<string, object>();
        }

        public void ReadConfig(string configFilePath)
        {
            // TODO: error handling if there's no file
            var doc = XDocument.Parse(File.ReadAllText(configFilePath));
            var rootNode = doc.Root;
            rootNode.Descendants()
                .Where(node => node.Name.LocalName == "setting")
                .ToList()
                .ForEach(node => Settings.Add(node.Element("name").Value, node.Element("value").Value));
        }
    }
}