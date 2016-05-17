using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    public class Problem242Test
    {
        private Problem242 _problem242;

        [SetUp]
        public void Initialize()
        {
            _problem242 = new Problem242();
        }

        [Test]
        public void TestIsAnagramInvalidInputs()
        {
            Assert.IsFalse(_problem242.IsAnagram(null, null));

            Assert.IsFalse(_problem242.IsAnagram("someString", null));

            Assert.IsFalse(_problem242.IsAnagram(null, "someString"));

            Assert.IsFalse(_problem242.IsAnagram(" ", ""));

            Assert.IsFalse(_problem242.IsAnagram("", " "));
        }

        [Test]
        public void TestIsAnagramInputsAreEmptyStringOrWhiteSpaces()
        {
            Assert.IsTrue(_problem242.IsAnagram("", ""));
            Assert.IsTrue(_problem242.IsAnagram(" ", " "));
        }

        [Test]
        public void TestIsAnagramInputsAreAnagrams()
        {
            Assert.IsTrue(_problem242.IsAnagram("anagram", "nagaram"));

            Assert.IsTrue(_problem242.IsAnagram("science", "ciecens"));
        }

        [Test]
        public void TestIsAnagramInputsAreNotAnagrams()
        {
            Assert.IsFalse(_problem242.IsAnagram("anagram", "nagarams"));

            Assert.IsFalse(_problem242.IsAnagram("science", "sciecens"));

            Assert.IsFalse(_problem242.IsAnagram("anagram", "nageram"));
        }

    }
}
