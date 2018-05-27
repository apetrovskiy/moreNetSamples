namespace ChainOfResponsibilityPattern.ObjectModel
{
    using System.IO;

    public class ReaderFactory
    {
        public static DataFileReader GetReader(string filePath, bool isRealFile = true)
        {
            if (!isRealFile) return null;
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Cannot find file " + filePath);
            var extension = filePath.Substring(filePath.LastIndexOf(".") + 1).ToUpper();

            switch (extension)
            {
                case "XML":
                    return new XmlReader(filePath);
                case "JSON":
                    return new JsonReader(filePath);
                case "CSV":
                    return new CsvReader(filePath);
                case "TSV":
                    return new TsvReader(filePath);
                default:
                    return null;
             }

        }
    }
}