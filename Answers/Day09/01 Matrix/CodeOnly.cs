public class Solution
{
    public int[][] UpdateMatrix(int[][] mat)
    {
        int rowLength = mat.Length;
        int colomnLength = mat[0].Length;
        int max = rowLength + colomnLength;

        for (int row = 0; row < rowLength; row++)
        {
            for (int column = 0; column < colomnLength; column++)
            {
                if (mat[row][column] == 0)
                {
                    continue;
                }

                int top = max;
                int left = max;

                if (row > 0)
                {
                    top = mat[row - 1][column];
                }

                if (column > 0)
                {
                    left = mat[row][column - 1];
                }

                mat[row][column] = Math.Min(top, left) + 1;
            }
        }

        for (int row = rowLength - 1; row >= 0; row--)
        {
            for (int column = colomnLength - 1; column >= 0; column--)
            {
                if (mat[row][column] == 0)
                {
                    continue;
                }

                int bottom = max;
                int right = max;

                if (row < rowLength - 1)
                {
                    bottom = mat[row + 1][column];
                }

                if (column < colomnLength - 1)
                {
                    right = mat[row][column + 1];
                }

                mat[row][column] = Math.Min(mat[row][column], Math.Min(bottom, right) + 1);
            }
        }
        return mat;
    }


}
