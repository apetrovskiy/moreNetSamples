using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Server.UnitTests
{
	using System.Threading;
	using Model;
	using Modules.V1;
	using Nancy;
    using Nancy.Testing;
    using NUnit.Framework;

    public class V1Tests
    {
        private Browser sut;

        private BrowserResponse actual;

        [SetUp]
        public void SetUp()
        {
            sut = new Browser(with => with.Module<CatsModule>());
			Data.Cats = new List<Cat>();
        }

        [Test]
        public void ShouldNotAllowCreatingCatWithTheSameName()
        {
            this.GivenWeCreateCat();
            Assert.AreEqual(HttpStatusCode.Created, actual.StatusCode);
            this.GivenWeCreateCat();
            Assert.AreEqual(HttpStatusCode.NotAcceptable, actual.StatusCode);
        }

        [Test]
        
        public void ShouldReturnCatOnGetAfterPost()
        {
            this.GivenWeCreateCat();
            Assert.AreEqual(HttpStatusCode.Created, actual.StatusCode);
            this.ThenWeGetThatCat();

        }

        private void ThenWeGetThatCat()
        {
            actual = sut.Get("/v1/cats", with =>
            {
                with.Query("name", "Tiger");
                //with.jso
            });
            Assert.AreEqual(HttpStatusCode.OK, actual.StatusCode);
        }

        private void GivenWeCreateCat()
        {
	        actual = sut.Post("/v1/cats", with => with.Query("name", "Tiger"));
		}
    }
}
