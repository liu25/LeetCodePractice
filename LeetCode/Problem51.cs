using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Problem51
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            var solutions = new List<IList<string>>();

            int row = 0;

            List<Tuple<int, int>> solusionIntArrayList = new List<Tuple<int, int>>();

            PickFromNthRow(row, n, solusionIntArrayList, solutions);

            return solutions;
        }

        private void PickFromNthRow(
            int row, 
            int dimension,
            List<Tuple<int, int>> solusionIntArrayList, 
            List<IList<string>> solutions)
        {
            for (int col = 0; col < dimension; col++)
            {
                if (!CanBeAttacked(solusionIntArrayList, row, col))
                {
                    List<Tuple<int, int>> copyOfSolutionIntTupleList = solusionIntArrayList.ToList();

                    copyOfSolutionIntTupleList.Add(new Tuple<int, int>(row, col));

                    // if last row
                    if (row == dimension - 1)
                    {
                        var solusion = GetBoard(copyOfSolutionIntTupleList);

                        solutions.Add(solusion);
                    }
                    else
                    {                        
                        PickFromNthRow(row + 1, dimension, copyOfSolutionIntTupleList, solutions);
                    }
                }
            }
        }

        private bool CanBeAttacked(List<Tuple<int, int>> queens, int row, int col)
        {
            foreach (var queen in queens)
            {
                if (queen.Item1 == row || queen.Item2 == col)
                    return true;

                if (Math.Abs(row - queen.Item1) == Math.Abs(col - queen.Item2))
                    return true;
            }

            return false;
        }

        private IList<string> GetBoard(List<Tuple<int, int>> queens)
        {
            List<string> board = new List<string>();

            foreach (var queen in queens)
            {
                board.Add(GetRow(queen, queens.Count));
            }

            return board;
        }

        private string GetRow(Tuple<int, int> queen, int count)
        {
            char[] charArray = new char[count];

            for (int i = 0; i < count; i++)
            {

                if (queen.Item2 == i)
                    charArray[i] = 'Q';
                else
                {
                    charArray[i] = '.';
                }
            }

            return new string(charArray);
        }
    }
}
