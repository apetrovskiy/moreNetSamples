namespace Animals.Server.Tests
{
    using System.Net;
    using NUnit.Framework;
    using RestSharp;

    public class Deletion
    {
        private string url;
        public Deletion(string url)
        {
            this.url = url;
        }

        internal void DeleteCatByName(string name)
        {
            var request = new RestRequest(Method.DELETE);
            request.AddParameter("name", name, ParameterType.QueryString);
            var client = new RestClient(url);
            var response = client.Execute(request);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}