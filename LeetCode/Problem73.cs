namespace LeetCode
{
    public class Problem73
    {
        public void SetZeroes(int[,] matrix)
        {
            int row = matrix.GetLength(0), col = matrix.GetLength(1);
            bool zerorow = false, zerocol = false;

            for (int i = 0; i < col; i++)
                if (matrix[0, i] == 0)
                {
                    zerorow = true;
                    break;
                }
                    
            for (int i = 0; i < row; i++)
                if (matrix[i, 0] == 0)
                {
                    zerocol = true;
                    break;
                }

            for (int i = 1; i < row; i++)
                for (int j = 1; j < col; j++)
                    if (matrix[i, j] == 0)
                    {
                        matrix[0, j] = 0;
                        matrix[i, 0] = 0;
                    }

            for (int i = 1; i < row; i++)
                for (int j = 1; j < col; j++)
                    if (matrix[i, 0] == 0 || matrix[0, j] == 0)
                        matrix[i, j] = 0;

            if (zerorow)
                for (int i = 0; i < col; i++)
                    matrix[0, i] = 0;

            if (zerocol)
                for (int i = 0; i < row; i++)
                    matrix[i, 0] = 0;
        }
    }
}
