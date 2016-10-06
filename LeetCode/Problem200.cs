using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem200
    {
        public int NumIslands(char[,] grid)
        {
            if (grid == null)
                return 0;

            int count = 0;

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == '1')
                    {
                        count++;

                        Merge(grid, i, j);
                    }
                }
            }

            return count;
        }

        private void Merge(char[,] grid, int i, int j)
        {
            if (i < 0 || i >= grid.GetLength(0) || j < 0 || j > grid.GetLength(1))
                return;

            if (grid[i, j] != '1')
                return;

            grid[i, j] = 'X';

            Merge(grid, i, j + 1);
            Merge(grid, i, j - 1);
            Merge(grid, i + 1, j);
            Merge(grid, i - 1, j);
        }
    }
}
