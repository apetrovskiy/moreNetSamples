namespace SeOnCore.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            new SimpleTest().Run(false);

			/*
			GET
			http://localhost:63104/sessions
			POST
			http://localhost:63104/session/cdf7ba9c7730ff45ccb29fdb7a8493de/url
			{"url":"http://pluralsight.com"}
			*/
		}
	}
}
