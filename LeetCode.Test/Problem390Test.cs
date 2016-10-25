using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem390Test
    {
        [Test]
        public void TestLastRemaining()
        {
            Problem390 problem390 = new Problem390();

            problem390.LastRemaining(7);
        }

        [Test]
        public void SpeedTest()
        {
            int n = 1000000000;

            Problem390 problem390 = new Problem390();

            Stopwatch sw = new Stopwatch();

            sw.Start();

            problem390.LastRemaining(n);

            sw.Stop();

            Console.WriteLine(sw.Elapsed);

            sw.Reset();

            sw.Start();

            problem390.LastRemaining1(n);

            sw.Stop();

            Console.WriteLine(sw.Elapsed);

            sw.Reset();

            sw.Start();

            problem390.LastRemaining2(n);

            sw.Stop();

            Console.WriteLine(sw.Elapsed);

            sw.Reset();
        }
    }
}
