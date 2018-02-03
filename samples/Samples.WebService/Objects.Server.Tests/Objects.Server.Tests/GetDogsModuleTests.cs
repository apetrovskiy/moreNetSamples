namespace Objects.Server.Tests
{
	using System.Net;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using RestSharp;

	[TestClass]
	public class GetDogsModuleTests
	{
		private RestClient client;
		private RestRequest request;
		private IRestResponse response;

	    public GetDogsModuleTests()
	    {
		    client = new RestClient("http://localhost:1234/v1/dogs");
	    }

		[TestMethod]
        public void GetDogByName()
        {
	        var name = "Rex";
	        WhenIcreateDogWithName(name);
	        ThenIcanGetDogByName(name);
        }

		[TestMethod]
		public void ShouldNotAllowPostingOfDogsWithTheSameName()
		{
			var name = "Rex";
			WhenIcreateDogWithName(name);
			ThenIgetNotAcceptableOnSubsequentPosting(name);
		}

		private void ThenIgetNotAcceptableOnSubsequentPosting(string name)
		{
			request = new RestRequest(Method.POST);
			request.AddParameter("name", name, ParameterType.QueryString);
			response = client.Execute(request);
			Assert.AreEqual(HttpStatusCode.NotAcceptable, response.StatusCode);
		}

		private void WhenIcreateDogWithName(string name)
	    {
		    request = new RestRequest(Method.POST);
		    request.AddParameter("name", name, ParameterType.QueryString);
		    response = client.Execute(request);
			Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
	    }

	    private void ThenIcanGetDogByName(string name)
	    {
		    request = new RestRequest(Method.GET);
		    request.AddParameter("name", name, ParameterType.QueryString);
		    response = client.Execute(request);
			Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
	    }
	}
}
