using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem4Test
    {
        private readonly Problem4 _problem4 = new Problem4();

        [Test]
        public void TestFindMedianSortedArraysEvenNumbers()
        {
            int[] nums1 = {1, 3, 5, 7};

            int[] nums2 = {2, 4, 6, 8};

            var median = _problem4.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(median, 4.5);
        }

        [Test]
        public void TestFindMedianSortedArraysOddNumbers()
        {
            int[] nums1 = { 1, 3, 5, 7, 9 };

            int[] nums2 = { 2, 4, 6, 8 };

            var median = _problem4.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(median, 5);
        }

    }
}
