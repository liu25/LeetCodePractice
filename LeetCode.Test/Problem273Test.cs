using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem273Test
    {
        [Test]
        public void TestNumberToWords()
        {
            Problem273 problem273 = new Problem273();

            Assert.AreEqual(problem273.NumberToWords(0), "Zero");

            Assert.AreEqual(problem273.NumberToWords(5), "Five");

            Assert.AreEqual(problem273.NumberToWords(15), "Fifteen");

            Assert.AreEqual(problem273.NumberToWords(125), "One Hundred Twenty Five");

            Assert.AreEqual(problem273.NumberToWords(1256), "One Thousand Two Hundred Fifty Six");

            Assert.AreEqual(problem273.NumberToWords(12567), "Twelve Thousand Five Hundred Sixty Seven");

            Assert.AreEqual(problem273.NumberToWords(123000567), "One Hundred Twenty Three Million Five Hundred Sixty Seven");

            Assert.AreEqual(problem273.NumberToWords(1234567891), "One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety One");
            

        }
    }
}
