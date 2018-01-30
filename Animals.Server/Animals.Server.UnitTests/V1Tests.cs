using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Server.UnitTests
{
	using System.Threading;
	using Model;
	using Modules;
	using Nancy;
    using Nancy.Testing;
    using NUnit.Framework;

    public class V1Tests
    {
        private Browser sut;

        [SetUp]
        public void SetUp()
        {
            sut = new Browser(with => with.Module<CatsModule>());
			Data.Cats = new List<Cat>();
        }

        [Test]
        public void ShouldReturnCatOnGetAfterPost()
        {
            this.GivenWeCreateCat();
            this.ThenWeGetThatCat();
        }

        private void ThenWeGetThatCat()
        {
            var actual = sut.Get("/v1/cats", with => with.FormValue("name", "Tiger"));
            Assert.AreEqual(HttpStatusCode.OK, actual.StatusCode);
        }

        private void GivenWeCreateCat()
        {
	        var actual = sut.Post("/v1/cats", with => with.Query("name", "Tiger"));
			Assert.AreEqual(HttpStatusCode.Created, actual.StatusCode);
        }
    }
}
