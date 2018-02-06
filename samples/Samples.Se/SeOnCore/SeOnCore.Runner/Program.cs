namespace SeOnCore.Runner
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // new SimpleTest().RunFirefoxSample();
            // new SimpleTest().RunInternetExplorerDriverSample();
            new SimpleTest().RunChromeDriverSample(false);

			/*
			GET
			http://localhost:63104/sessions
			POST
			http://localhost:63104/session/cdf7ba9c7730ff45ccb29fdb7a8493de/url
			{"url":"http://pluralsight.com"}
			*/
            Console.ReadKey();
            new SimpleTest().RunChromeDriverFindingElementSample();
        }
	}
}
