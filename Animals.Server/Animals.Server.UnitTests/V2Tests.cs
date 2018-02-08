namespace Animals.Server.UnitTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;
    using Modules.V2;
    using Nancy.Testing;
    using NUnit.Framework;
    using Browser = Nancy.Testing.Browser;

    public class V2Tests
    {
        private Browser sut;

        private Task<BrowserResponse> actual;

        public V2Tests()
        {
            sut = new Browser(with => with.Module<CatsModule>());
            Data.Cats = new List<Cat>();
        }

        [Test]
        public void ShouldReturnObjectBeingPosted()
        {
            //given
            // arrange
            var cat = new Cat {Id = 9, Color = "black", Name = "Cat", Owned = true};

            // when
            // act
            actual = sut.Post("/v2/newcat.json", context => context.JsonBody(cat));
            actual = sut.Get("/v2/cats.json", context =>
            {
                context.JsonBody(cat);
                context.Query("name", "Cat");
            });


            // then
            // assert
            var result = actual.Result.Body.DeserializeJson<Cat>();
            Assert.AreEqual(cat.Id, result.Id);
            Assert.AreEqual(cat.Color, result.Color);
        }
    }
}