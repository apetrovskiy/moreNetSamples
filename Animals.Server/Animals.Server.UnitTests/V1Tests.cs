using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Server.UnitTests
{
    using Nancy;
    using Nancy.Testing;
    using NUnit.Framework;

    public class V1Tests
    {
        private Browser sut;

        [SetUp]
        public void SetUp()
        {
            sut = new Browser(new DefaultNancyBootstrapper());
        }

        [Test]
        public void ShouldReturnCatOnGetAfterPost()
        {
            this.GivenWeCreateCat();
            this.ThenWeGetThatCat();
        }

        private void ThenWeGetThatCat()
        {
            var actual = sut.Get("v1/cats?name=Tiger");
            Assert.AreEqual(HttpStatusCode.OK, actual.StatusCode);
        }

        private void GivenWeCreateCat()
        {
            // var actual = sut.Post("v1/cats?name=Tiger");
            // var actual = sut.Post("cats?name=Tiger");
            // var actual = sut.Post("http://localhost:1235/v1/cats?name=Tiger");
            var actual = sut.Post("/v1/cats?name=Tiger");
            // var actual = sut.Post("/cats?name=Tiger");
            // var actual = sut.Post("/?name=Tiger");
            // var actual = sut.Post("?name=Tiger");
            Assert.AreEqual(HttpStatusCode.Created, actual.StatusCode);
        }
    }
}
