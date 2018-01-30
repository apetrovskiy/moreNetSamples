namespace SingleResponsibilityPrinciple.ObjectModel
{
    using System.Collections.Generic;
    using System.IO;
    using Types;

    public abstract class DataFileReader
    {
        public abstract IEnumerable<TradeItem> LoadFromFile(string fullFilePath);

        protected void CheckInputFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Cannot find file " + filePath);
        }
        
    }
}