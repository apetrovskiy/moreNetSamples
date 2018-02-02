namespace Animals.Server.UnitTests
{

	using Model;
	using Modules.V1;
	using Nancy;
    using Nancy.Testing;
    using NUnit.Framework;
    using System.Collections.Generic;
	using System.Threading.Tasks;
	using Modules.V2;

    public class V1Tests
    {
        private Browser sut;

        private Task<BrowserResponse> actual;

        private string version;

        [SetUp]
        public void SetUp()
        {
            sut = new Browser(with => with.Modules(typeof(CatsV1Module), typeof(CatsModule)));
			Data.Cats = new List<Cat>();
        }

        static object[] Versions =
        {
            new object[] { Constants.Version01 },
            new object[] { Constants.Version02 }
        };

        [Test, TestCaseSource("Versions")]
        public void ShouldNotAllowCreatingCatWithTheSameName(string version)
        {
            this.version = version;
            this.GivenWeCreateCat();
            Assert.AreEqual(HttpStatusCode.Created, actual.Result.StatusCode);
            this.GivenWeCreateCat();
            Assert.AreEqual(HttpStatusCode.NotAcceptable, actual.Result.StatusCode);
        }

        [Test, TestCaseSource("Versions")]

        public void ShouldReturnCatOnGetAfterPost(string version)
        {
            this.version = version;
            this.GivenWeCreateCat();
            Assert.AreEqual(HttpStatusCode.Created, actual.Result.StatusCode);
            this.ThenWeGetThatCat();

        }

        [Test, TestCaseSource("Versions")]

        public void ShouldReturnNotFoundAfterDelete(string version)
        {
            this.version = version;
            this.GivenWeCreateCat();
            Assert.AreEqual(HttpStatusCode.Created, actual.Result.StatusCode);
            this.ThenWeDeleteThatCat();
            Assert.AreEqual(HttpStatusCode.OK, actual.Result.StatusCode);

        }

        private void ThenWeDeleteThatCat()
        {
            actual = sut.Delete($"/{version}/cats", with => with.Query("name", "Tiger"));
        }

        private void ThenWeGetThatCat()
        {
            actual = sut.Get($"/{version}/cats.xml", with =>
            {
                with.Query("name", "Tiger");
            });
            Assert.AreEqual(HttpStatusCode.OK, actual.Result.StatusCode);
        }

        private void GivenWeCreateCat()
        {
	        actual = sut.Post($"/{version}/cats", with => with.Query("name", "Tiger"));
		}
    }
}
