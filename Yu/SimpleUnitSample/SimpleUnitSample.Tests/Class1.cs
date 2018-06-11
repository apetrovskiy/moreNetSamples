using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
using SimpleUnitSample.ObjectModel;
using SimpleUnitSample.Tests.Fakes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUnitSample.Tests
{

    [TestClass]
   //[TestFixture]
    public class Class1
    {
        //[Test]
        [TestMethod]
       public void test1()
        {
            // Arrange
            var parser = new ParserType1(new FakeLogReader());

            // Act
            var result = parser.Parse(@"C:\Projects\DotNet\Yu\SimpleUnitSample\SimpleUnitSample.Tests\bin\Debug\Logs\log1.txt");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Count());
        }

        // [Info: 11:32:03 25.05.18] Disconnected from Endur
        //[Test]
        [TestMethod]
        public void parseStringStd()
        {
            // Arrange
            var logReader = new FakeLogReader();
            logReader.LogType = 1;
            var parser = new ParserType1(logReader);

            // Act
            var result = parser.Parse(@"C:\Projects\DotNet\Yu\SimpleUnitSample\SimpleUnitSample.Tests\bin\Debug\Logs\log1.txt");

            // Assert
            Assert.AreEqual("Info", result[0].level.ToString());
            Assert.AreEqual("11:32:03 25.05.18", result[0].timeStamp.ToString());
          //  Assert.AreEqual("Disconnected from Endur", result[0].message);
        }
    }
}
