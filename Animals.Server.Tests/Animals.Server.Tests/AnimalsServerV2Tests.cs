namespace Animals.Server.Tests
{
    using System;
    using System.Net;
    using Newtonsoft.Json.Linq;
    using NUnit.Framework;
    using RestSharp;
    using SimpleJson;

    public class AnimalsServerV2Tests
    {
        RestClient client;

        RestRequest request;

        IRestResponse response;

        private Deletion _deletion;

        public AnimalsServerV2Tests()
        {
            this._deletion = new Deletion(URLs.UrlToCatsV2);
        }

        [SetUp]
        public void AnimalServerV2Tests1()
        {
            this.client = new RestClient(URLs.Newcat);
        }


        [Test]
        public void ShouldReturnCatOnGetAfterPostOfObject()
        {
            var cat = this.GivenWeCreateCatFromObject();
            Assert.AreEqual(HttpStatusCode.Created, this.response.StatusCode);
            this.ThenWeGetThatCat(cat);
        }

        private void ThenWeGetThatCat(object cat)
        {
            const string Expected = @"{
  'id': 9,
  'name': 'Cat',
  'color': 'black',
  'owned': true,
  'age': 12
}";
            var tempclient = new RestClient("http://localhost:1235/v2/cats");
            this.request = new RestRequest(Method.GET);
            this.request.AddParameter("name", "Cat", ParameterType.QueryString);

            // this.request.AddObject(cat);

            this.response = tempclient.Execute(this.request);
            var jsonString = response.Content;
            var json = JObject.Parse(jsonString);
           // "{\"id\":9,\"name\":\"Cat\",\"color\":\"black\",\"owned\":true,\"age\":12}"

            var actual = json.ToString().Replace("\"", "'");
            actual = actual.Replace(" ", String.Empty);

            var expected = JObject.Parse(Expected);
            Assert.AreEqual(expected, json);
        }

        [Test]
        [Ignore("nah")]
        public void ShouldReturnCatOnGetAfterPostOfJson()
        {
            this.GivenWeCreateCatFromJson();

            //Assert.AreEqual(HttpStatusCode.Created, this.response.StatusCode);
            //  this.ThenWeGetThatCat();
        }
        /*
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public bool Owned { get; set; }
        public int Age { get; set; }
        */

        private const string NewCat = @"{
    ""id"": 3,
    ""name"": ""Barsik5"",
    ""color"": null,
    ""owned"": false,
    ""age"": 0
}";

        private object GivenWeCreateCatFromObject()
        {
            this.request = new RestRequest(Method.POST);
           var cat = new
            {
                Id = 9, Name = "Cat", Color = "black", Owned = true, Age = 12
            };
           this.request.AddObject(cat);

            this.response = this.client.Execute(this.request);
            return cat;
        }

        private void GivenWeCreateCatFromJson()
        {
            this.request = new RestRequest(Method.POST);
            this.request.AddJsonBody(NewCat);

            this.response = this.client.Execute(this.request);

        }

        [TearDown]

        public void DeleteTestCat()
        {
            _deletion.DeleteCatByName("Cat");
        }
    }
}