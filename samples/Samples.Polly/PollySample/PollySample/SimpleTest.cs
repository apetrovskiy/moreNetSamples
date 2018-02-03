namespace PollySample
{
	using System;
	using System.Net;
	using Polly;

	public class SimpleTest
    {
	    public void Run()
	    {
		    var policy = Policy<MyResult>
			    .HandleResult(r => r.StatusCode == HttpStatusCode.BadRequest)
				.OrResult(r => r.StatusCode == HttpStatusCode.ExpectationFailed)
			    .Retry(3);

			policy.ExecuteAndCapture(() =>
			{
				int i = 0;
				Console.WriteLine("preparing to an exception...");
				try {var j = 1 / i;} catch { return new MyResult(HttpStatusCode.ExpectationFailed); }
				Console.WriteLine("done");
				return new MyResult(HttpStatusCode.OK);
			});
	    }
    }
}
