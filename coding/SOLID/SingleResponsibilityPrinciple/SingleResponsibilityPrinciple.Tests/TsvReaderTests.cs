
using System.Linq;

namespace SingleResponsibilityPrinciple.Tests
{
    using NUnit.Framework;
    using ObjectModel;
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
            var actual = sut.ProcessLines(inputData.Split('\r'));

            // Assert.Fail();
            Assert.AreEqual(2, actual.First().Id);
            Assert.AreEqual(600.00, actual.First().Amount);
            Assert.AreEqual("milk", actual.First().Name);
            Assert.AreEqual(39.99, actual.First().Price);
        }
    }
}
