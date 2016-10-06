namespace LeetCode
{
    public class Problem74
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            int height = matrix.GetLength(0);

            int length = matrix.GetLength(1);            

            return SearchRecursiveLy(matrix, new[] { 0, 0 }, new[] { height - 1, length - 1 }, target, length);
        }

        private bool SearchRecursiveLy(int[,] matrix, int[] start, int[] end, int target, int length)
        {
            if (end[0] == start[0] && end[1] == start[1])
            {
                return matrix[start[0], start[1]] == target;
            }

            int diff = GetDiff(start, end, length);

            if (diff == 1)
            {
                return matrix[start[0], start[1]] == target || matrix[end[0], end[1]] == target;
            }

            int[] med = GetMedium(start, end, length);

            int cur = matrix[med[0], med[1]];
            if (cur == target)
                return true;

            if (cur > target)
            {
                return SearchRecursiveLy(matrix, start, med, target, length);
            }
            return SearchRecursiveLy(matrix, med, end, target, length);
        }

        private int GetDiff(int[] start, int[] end, int length)
        {
            return (end[0] - start[0])*length + end[1] - start[1];
        }

        private int[] GetMedium(int[] start, int[] end, int length)
        {
            int diff = GetDiff(start, end, length);

            int heighDiff = diff/2/length;
            int lengthDiff = diff/2 >= length ? diff/2%length : diff >= 2 ? diff/2 : diff;

            int b = start[1] + lengthDiff;

            int a = start[0] + heighDiff + b / length;

            b = b >= length ? b%length : b;

            return new[] {a, b};
        }
    }
}
