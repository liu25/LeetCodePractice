using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem168Test
    {
        private Problem168 _problem168;

        [SetUp]
        public void Initialize()
        {
            _problem168 = new Problem168();
        }

        [Test]
        public void TestConvertToTitleInputLessEqualTo26()
        {
            Assert.AreEqual(_problem168.ConvertToTitle(1), "A");

            Assert.AreEqual(_problem168.ConvertToTitle(2), "B");

            Assert.AreEqual(_problem168.ConvertToTitle(26), "Z");
        }

        [Test]
        public void TestConvertToTitleInputGreaterThan26()
        {
            Assert.AreEqual(_problem168.ConvertToTitle(27), "AA");

            Assert.AreEqual(_problem168.ConvertToTitle(28), "AB");

            Assert.AreEqual(_problem168.ConvertToTitle(52), "AZ");
        }

        [Test]
        public void TestConvertToTitleInputGreaterThan26SquareFoot()
        {
            Assert.AreEqual(_problem168.ConvertToTitle(100), "CV");

            Assert.AreEqual(_problem168.ConvertToTitle(1000), "ALL");
        }
    }
}
