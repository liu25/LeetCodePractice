using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem51Test
    {
        private Problem51 _problem51;

        [SetUp]
        public void Initialize()
        {
            _problem51 = new Problem51();
        }

        [Test]
        public void Test4Queens()
        {
            var solutions = _problem51.SolveNQueens(4);

            Assert.AreEqual(solutions.Count, 2);

            foreach (var solution in solutions)
            {
                Print(solution);
            }
        }

        [Test]
        public void Test5Queens()
        {
            var solutions = _problem51.SolveNQueens(5);

           // Assert.AreEqual(solutions.Count, 4);

            foreach (var solution in solutions)
            {
                Print(solution);
            }
        }

        private void Print(IList<string> solution)
        {
            foreach (var row in solution)
            {
                Console.WriteLine(row);
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
