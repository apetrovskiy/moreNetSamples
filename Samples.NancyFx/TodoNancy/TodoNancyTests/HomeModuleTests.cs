namespace TodoNancyTests
{
    using Nancy;
    using Nancy.Testing;
    using Xunit;

    public class HomeModuleTests
    {
        [Fact]
        public void ShouldAnswer200OnRootPath()
        {
            var sut = new Browser(new DefaultNancyBootstrapper());
            var actual = sut.Get("/");
            Assert.Equal(HttpStatusCode.OK, actual.StatusCode);
        }
    }
}
