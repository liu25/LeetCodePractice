using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem130
    {
        public void Solve(char[,] board)
        {
            int m = board.GetLength(0);
            int n = board.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                if (board[i, 0] == 'O')
                    Merge(board, i, 0);

                if (board[i, n -1] == 'O')
                    Merge(board, i, n - 1);
            }

            for (int j = 0; j < n; j++)
            {
                if (board[0, j] == 'O')
                    Merge(board, 0, j);

                if (board[m - 1, j] == 'O')
                    Merge(board, m - 1, j);
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] == 'O')
                        board[i, j] = 'X';
                    else if (board[i, j] == '#')
                        board[i, j] = 'O';
                }
            }
        }

        public void Merge(char[,] board, int x, int y)
        {
            if (x < 0 || x >= board.GetLength(0) || y < 0 || y >= board.GetLength(1))
                return;

            if (board[x, y] != 'O')
                return;

            board[x, y] = '#';

            Merge(board, x-1, y);

            Merge(board, x+1, y);

            Merge(board, x, y-1);

            Merge(board, x, y+1);
        }
    }
}
