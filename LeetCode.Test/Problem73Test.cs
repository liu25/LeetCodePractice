using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    public class Problem73Test
    {
        [Test]
        public void TestSetZeroes()
        {
            Problem73 problem73 = new Problem73();

            problem73.SetZeroes(new[,]
            {
                { 1, 1, 1 ,1 },
                { 1, 1, 1 ,1 },
                { 1, 1, 0 ,1 },
                { 1, 1, 1 ,0 }
            });
        }
    }
}
