
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
        private readonly Deletion _deletion;

        public AnimalServerV1Tests()
        {
            _deletion = new Deletion(URLs.UrlToCatsV1);
        }

        [SetUp]
        public void AnimalServerV1Tests1()
        {
            this.client = new RestClient(URLs.UrlToCatsV1);
        }


        [Test]
        public void ShouldNotAllowCreatingCatWithTheSameName()
        {
            this.GivenWeCreateCat();
            Assert.AreEqual(HttpStatusCode.Created, this.response.StatusCode);
            this.GivenWeCreateCat();
            Assert.AreEqual(HttpStatusCode.NotAcceptable, this.response.StatusCode);
            this.ThenWeGetThatCat();
            Assert.AreEqual(HttpStatusCode.OK, this.response.StatusCode);
        }


        private void ThenWeGetThatCat()
        {
            this.request = new RestRequest(Method.GET);
            this.request.AddParameter("name", "Tiger", ParameterType.QueryString);
            this.response = this.client.Execute(this.request);
        }

        [Test]
        public void ShouldReturnCatOnGetAfterPost()
        {
            this.GivenWeCreateCat();
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
        }

        [TearDown]

        public void DeleteTestCat()
        {
            _deletion.DeleteCatByName("Tiger");
        }
    }
}
