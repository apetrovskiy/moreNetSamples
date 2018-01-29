
namespace Animals.Server.Tests
{
    using System.Net;

    using NUnit.Framework;

    using RestSharp;

    public class AnimalServerV1Tests
    {
        RestClient client;

        RestRequest request;

        IRestResponse response;

        [SetUp]
        public void AnimalServerV1Tests1()
        {
            this.client = new RestClient("http://localhost:1235/v1/cats");
        }

        [Test]
        public void ShouldReturnCatOnGetAfterPost()
        {
            this.GivenWeCreateCat();
            this.ThenWeGetThatCat();
        }

        private void ThenWeGetThatCat()
        {
            this.request = new RestRequest(Method.GET);
            this.request.AddParameter("name", "Tiger", ParameterType.QueryString);
            this.response = this.client.Execute(this.request);
            Assert.AreEqual(HttpStatusCode.OK, this.response.StatusCode);
        }

        private void GivenWeCreateCat()
        {
            this.request = new RestRequest(Method.POST);
            this.request.AddParameter("name", "Tiger", ParameterType.QueryString);
            this.response = this.client.Execute(this.request);
            Assert.AreEqual(HttpStatusCode.Created, this.response.StatusCode);
        }

        [TearDown]

        public void DeleteTestCat()
        {
            this.request = new RestRequest(Method.DELETE);
            this.request.AddParameter("name", "Tiger", ParameterType.QueryString);
            this.response = this.client.Execute(this.request);
            Assert.AreEqual(HttpStatusCode.OK, this.response.StatusCode);

        }
    }
}
