namespace SeOnCore
{
    using System;
    using System.IO;
    using OpenQA.Selenium;
	using OpenQA.Selenium.Chrome;
	using OpenQA.Selenium.Firefox;
	using OpenQA.Selenium.IE;

    public class SimpleTest
    {
        private const string LibrariesFolder = @"..\..\Libraries\";
        private const string GoogleUrl = "http://www.google.com";

        public void RunFirefoxSample()
	    {
	        var driver = new FirefoxDriver();
	        driver.Url = GoogleUrl;
	    }

	    public void RunInternetExplorerDriverSample()
	    {
            Console.WriteLine(Environment.CurrentDirectory);
	        Console.WriteLine(Path.Combine(Environment.CurrentDirectory, LibrariesFolder));
            var driver = new InternetExplorerDriver(LibrariesFolder);
	        driver.Url = GoogleUrl;
	    }

		public void RunChromeDriverSample(bool closeDriver)
		{
			var driver = new ChromeDriver(LibrariesFolder);
			driver.Navigate().GoToUrl(GoogleUrl);
			var query = driver.FindElement(By.Name("q"));
			query.SendKeys("Hello Selenium!");
			query.Submit();
			if (!closeDriver) return;
			driver.Close();
			driver.Dispose();
		}

	    public void RunChromeDriverFindingElementSample()
	    {
	        var driver = new ChromeDriver(LibrariesFolder);
	        driver.Navigate().GoToUrl(GoogleUrl);

	        var searchBox = driver.FindElement(By.Id("lst-ib"));
            searchBox.SendKeys("pluralsight");
	    }
	}
}