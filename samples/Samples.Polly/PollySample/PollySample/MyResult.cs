namespace PollySample
{
	using System.Net;

	public class MyResult
	{
		public HttpStatusCode StatusCode { get; set; }

		public MyResult(HttpStatusCode code)
		{
			StatusCode = code;
		}
	}
}