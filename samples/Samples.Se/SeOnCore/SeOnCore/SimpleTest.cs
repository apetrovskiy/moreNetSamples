namespace SeOnCore
{
	using OpenQA.Selenium;
	using OpenQA.Selenium.Chrome;

	public class SimpleTest
	{
		public void Run(bool closeDriver)
		{
			var driver = new ChromeDriver(@"C:\Libraries\");
			driver.Navigate().GoToUrl("http://www.google.com");
			var query = driver.FindElement(By.Name("q"));
			query.SendKeys("Hello Selenium!");
			query.Submit();
			if (!closeDriver) return;
			driver.Close();
			driver.Dispose();
		}
	}
}