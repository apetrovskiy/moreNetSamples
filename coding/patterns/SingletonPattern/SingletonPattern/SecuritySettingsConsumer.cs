namespace SingletonPattern
{
    using System;
    using System.IO;

    public class SecuritySettingsConsumer
    {
        public void UseSecuritySettings()
        {
            var configReader = new ConfigReader();
            configReader.ReadConfig(Path.Combine(Environment.CurrentDirectory, @"bin\Debug\netcoreapp2.0", "config.xml"));
            var username = configReader.Settings[Constants.Username];
            Console.WriteLine(username);
        }
    }
}