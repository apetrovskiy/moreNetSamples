namespace Objects.Server.Tests.V1
{
    using Nancy;
    using Nancy.Testing;
    using Xunit;

    public class AddDogsModuleTests
    {
        private Browser sut;

        public AddDogsModuleTests()
        {
            sut = new Browser(new DefaultNancyBootstrapper());
        }

        [Fact]
        public void ShouldCreateDog()
        {
            sut.Post("/v1/dogs");
        }
    }
}