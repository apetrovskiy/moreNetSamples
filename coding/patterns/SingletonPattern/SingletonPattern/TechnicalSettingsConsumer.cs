namespace SingletonPattern
{
    using System;
    using System.IO;

    public class TechnicalSettingsConsumer
    {
        public void UseNumericalSettings()
        {
            var configReader = new ConfigReader();
            configReader.ReadConfig(Path.Combine(Environment.CurrentDirectory, @"bin\Debug\netcoreapp2.0", "config.xml"));
            var timeout = Convert.ToInt64(configReader.Settings[Constants.DefaultTimeout]);
            Console.WriteLine(timeout);
        }
    }
}