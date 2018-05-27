namespace FakesLib.Tests
{
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class MyTests
    {
        [Test]
        public void RegularClassShouldBeSupportedAsStub()
        {
            var regular = new Fakes.StubClass1 { StringData = "fff", IntData = 333 };
            Assert.AreEqual("fff", regular.StringData);
            Assert.AreEqual(333, regular.IntData);
        }

        [Test]
        public void RegularClassShouldBeSupportedAsShim()
        {
            var regular = new Fakes.ShimClass1();

            // all these three members have fixed values, thus demonstrate bugs
            regular.StringDataGet = () => { return "ccc"; };
            regular.StringDataSetString = (a) => a = "ddd";
            regular.IntDataGet = () => { return 555; };
            regular.GetNumbersInt32 = (count) => { var result = new List<int>(); result.Add(1); return result; };


        }

        [Test]
        public void StaticClassShouldBeSupportedAsShim()
        {
            Fakes.ShimStaticClass.GetNumbersInt32 = (a) =>
            {
                var result = new List<int>();
                result.Add(1);
                result.Add(2);
                return result;
            };
            Fakes.ShimStaticClass.StringDataGet = () => "ggg";



        }
    }
}
