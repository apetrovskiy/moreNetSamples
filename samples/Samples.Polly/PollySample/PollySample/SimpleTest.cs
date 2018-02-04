namespace PollySample
{
	using System;
	using System.Diagnostics;
	using System.Net;
	using System.Threading;
	using Polly;

	public class SimpleTest
    {
        public void RunPolicyWithTimeout()
        {
            /*
            var policy = Policy<MyResult>
                .Handle<TimeoutException>()
                .OrResult(r => r.StatusCode == HttpStatusCode.RequestTimeout)
                .OrResult(r => r.StatusCode == HttpStatusCode.GatewayTimeout)
                .WaitAndRetry(2, () => { Thread.Sleep(2000); })

            var result = policy.exe
                */
        }

	    public void RunPolicyWithRetry()
	    {
		    var policy = Policy<MyResult>
			    .HandleResult(r => r.StatusCode == HttpStatusCode.BadRequest)
				.OrResult(r => r.StatusCode == HttpStatusCode.ExpectationFailed)
			    .Retry(3);

			var result = policy.ExecuteAndCapture(() =>
			{
				int i = 0;
				Console.WriteLine("preparing to an exception...");
				try {var j = 1 / i;} catch { return new MyResult(HttpStatusCode.ExpectationFailed); }
				Console.WriteLine("retried");
				return new MyResult(HttpStatusCode.OK);
			});

            Console.WriteLine(result.FinalHandledResult.StatusCode);
	    }
    }
}
