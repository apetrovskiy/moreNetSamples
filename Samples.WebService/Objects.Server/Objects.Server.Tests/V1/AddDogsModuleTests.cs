namespace Objects.Server.Tests.V1
{
	using System.Collections.Generic;
	using Model;
	using Model.Dogs;
	using Modules.V1;
	using Nancy;
    using Nancy.Testing;
    using Xunit;

    public class AddDogsModuleTests
    {
        private Browser sut;

        public AddDogsModuleTests()
        {
            sut = new Browser(with => with.Modules(new[] {typeof(AddDogsModule), typeof(ShowDogsModule)}));
			Data.Dogs = new List<Dog>();
        }

        [Fact]
        public void ShouldCreateDog()
        {
	        var actual = sut.Post("/v1/dogs", with => with.Query("name", "Rex"));

			Assert.Equal(HttpStatusCode.Created, actual.StatusCode);
        }

	    [Fact]
	    public void ShouldNotAcceptPostingOfTheSameDog()
	    {
		    var actual = sut.Post("/v1/dogs", with => with.Query("name", "Rex"))
			    .Then
			    .Post("/v1/dogs", with => with.Query("name", "Rex"));

			Assert.Equal(HttpStatusCode.NotAcceptable, actual.StatusCode);
	    }
    }
}