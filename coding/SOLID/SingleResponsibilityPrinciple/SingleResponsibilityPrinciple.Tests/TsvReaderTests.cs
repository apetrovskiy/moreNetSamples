
namespace SingleResponsibilityPrinciple.Tests
{
    using NUnit.Framework;
    using ObjectModel;
    using Xunit;
    using Assert = NUnit.Framework.Assert;

    public class TsvReaderTests
    {
        //[Fact]
        [Test]
        public void ShouldReturnCollection()
        {
            var inputData = @"Id	Name	Price	Amount
2	milk	39.99	600.00";

            var sut = new TsvReader();
            sut.LoadFromFile();

            Assert.Fail();
        }
    }
}
