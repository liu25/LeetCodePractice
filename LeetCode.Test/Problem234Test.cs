using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem234Test
    {
        [Test]
        public void TestIsPalindrome()
        {
            Problem234 problem234 = new Problem234();

            Assert.IsTrue(problem234.IsPalindrome(new Problem234.ListNode(1)
            {
                next = new Problem234.ListNode(2)
                {
                    next = new Problem234.ListNode(3)
                    {
                        next = new Problem234.ListNode(2)
                        {
                            next = new Problem234.ListNode(1)
                        }
                    }
                }
            }));
        }
    }
}
