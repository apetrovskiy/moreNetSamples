namespace ChainOfResponsibilityPattern.ObjectModel
{
    using System.Collections.Generic;
    using System.IO;
    using Types;

    public class DataFileReader
    {
        public bool IsRealFile { get; set; }
        public DataFileReader(string fullFilePath, bool isRealFile = true)
        {
            IsRealFile = isRealFile;
            FullFilePath = fullFilePath;
            CheckInputFile(FullFilePath);
        }
        protected void CheckInputFile(string filePath)
        {
            if (!IsRealFile) return;
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Cannot find file " + filePath);
        }

        public string FullFilePath { get; set; }

        public virtual IEnumerable<TradeItem> LoadFromFile()
        {
            return new List<TradeItem>();
        }
    }
}