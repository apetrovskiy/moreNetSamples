namespace SeOnCore
{
	using OpenQA.Selenium;
	using OpenQA.Selenium.Chrome;

	public class SimpleTest
	{
		public void Run()
		{
			var driver = new ChromeDriver(@"C:\Libraries\");
			driver.Navigate().GoToUrl("http://www.google.com");
			var query = driver.FindElement(By.Name("q"));
			query.SendKeys("Hello Selenium!");
			query.Submit();
			driver.Close();
			driver.Dispose();
		}
	}
}