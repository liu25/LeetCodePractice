using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem37
    {
        public void SolveSudoku(char[,] board)
        {
            if (board.GetLength(0) < 9 || board.GetLength(1) < 9) return;
            SolSudoku(board, 0, 0);
        }

        bool SolSudoku(char[,] board, int iRow, int iCol)
        {
            if (iRow == 9) return true;

            int irow2, icol2;
            if (iCol == 8)
            {
                irow2 = iRow + 1;
                icol2 = 0;
            }
            else
            {
                irow2 = iRow;
                icol2 = iCol + 1;
            }

            if (board[iRow, iCol] != '.')
            {
                if (!IsValid(board, iRow, iCol)) return false;
                return SolSudoku(board, irow2, icol2);
            }

            for (int i = 1; i <= 9; i++)
            {
                board[iRow, iCol] = (char) ('0' + i);
                if (IsValid(board, iRow, iCol) && IsValid(board, irow2, icol2)) return true;
            }

            // reset grid 
            board[iRow, iCol] = '.';
            return false;
        }

        bool IsValid(char[,] board, int irow, int icol)
        {
            char val = board[irow,icol];
            if (val - '0' < 1 || val - '0' > 9) return false;

            // check row & col
            for (int i = 0; i < 9; i++)
            {
                if (board[irow,i] == val && i != icol) return false;
                if (board[i,icol] == val && i != irow) return false;
            }

            //check 3x3 box
            int irow0 = irow / 3 * 3;
            int icol0 = icol / 3 * 3;
            for (int i = irow0; i < irow0 + 3; i++)
            {
                for (int j = icol0; j < icol0 + 3; j++)
                {
                    if (board[i,j] == val && (i != irow || j != icol)) return false;
                }
            }

            return true;
        }
    }
}
