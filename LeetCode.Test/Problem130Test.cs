using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem130Test
    {
        [Test]
        public void TestSolve()
        {
            Problem130 problem130 = new Problem130();

            char[,] board = new char[,]
            {
                { 'X', 'X', 'X', 'X'},
                { 'X', 'O', 'O', 'X'},
                { 'X', 'X', 'O', 'X'},
                { 'X', 'O', 'X', 'X'},
            };

            problem130.Solve(board);

            Assert.AreEqual(board[3,1], 'O');

            board = new char[,]
            {
                {'X', 'X', 'X', 'X', 'X'},
                {'X', 'O', 'O', 'X', 'O'},
                {'X', 'X', 'O', 'X', 'X'},
                {'X', 'O', 'X', 'X', 'X'},
            };

            problem130.Solve(board);

            Assert.AreEqual(board[3, 1], 'O');

            Assert.AreEqual(board[1, 4], 'O');

        }
    }
}
