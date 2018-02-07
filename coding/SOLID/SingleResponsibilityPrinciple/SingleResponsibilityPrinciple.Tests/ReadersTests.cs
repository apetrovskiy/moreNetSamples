namespace SingleResponsibilityPrinciple.Tests
{
    using System.Linq;
    using System.Xml.Linq;
    using NUnit.Framework;
    using ObjectModel;
    using Assert = NUnit.Framework.Assert;

    public class ReadersTests
    {
        [Test]
        public void TsvReaderShouldReturnCollection()
        {
            var inputData = @"Id	Name	Price	Amount
2	milk	39.99	600.00";

            var sut = new TsvReader();
            var actual = sut.ProcessLines(inputData.Split('\r'));
            
            Assert.AreEqual(2, actual.First().Id);
            Assert.AreEqual(600.00, actual.First().Amount);
            Assert.AreEqual("milk", actual.First().Name);
            Assert.AreEqual(39.99, actual.First().Price);
        }

        [Test]
        public void CsvReaderShouldReturnCollection()
        {
            var inputData = @"Id,Name,Price,Amount
1,beef,300.00,1200.00";

            var sut = new CsvReader();
            var actual = sut.ProcessLines(inputData.Split('\r'));

            Assert.AreEqual(1, actual.First().Id);
            Assert.AreEqual(1200.00, actual.First().Amount);
            Assert.AreEqual("beef", actual.First().Name);
            Assert.AreEqual(300.00, actual.First().Price);
        }

        [Test]
        public void JsonReaderShouldReturnCollection()
        {
            var inputData = @"
[{
    'id' : 1,
    'name' : 'beer',
    'price' : 69.99,
    'amount' : 558.00
}]
";

            var sut = new JsonReader();
            var actual = sut.ProcessLines(inputData);

            Assert.AreEqual(1, actual.First().Id);
            Assert.AreEqual(558.00, actual.First().Amount);
            Assert.AreEqual("beer", actual.First().Name);
            Assert.AreEqual(69.99, actual.First().Price);
        }

        [Test]
        public void XmlReaderShouldReturnCollection()
        {
            var inputData = @"<items>
  <item>
    <id>1</id>
    <name>coffee</name>
    <price>149.99</price>
    <amount>3000.00</amount>
  </item>
</items>";

            var sut = new XmlReader();
            var actual = sut.ProcessLines(XDocument.Parse(inputData));

            Assert.AreEqual(1, actual.First().Id);
            Assert.AreEqual(3000.00, actual.First().Amount);
            Assert.AreEqual("coffee", actual.First().Name);
            Assert.AreEqual(149.99, actual.First().Price);
        }
    }
}
