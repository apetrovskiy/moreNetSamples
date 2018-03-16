namespace SingletonPattern.Runner
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var securitysettingsConsumer = new SecuritySettingsConsumer();
            securitysettingsConsumer.UseSecuritySettings();
            var numericalSettingsConsumer = new TechnicalSettingsConsumer();
            numericalSettingsConsumer.UseNumericalSettings();

            Console.ReadKey();
        }
    }
}
