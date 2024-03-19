public class Solution
{
    // Method to update the matrix with distances from nearest 0
    public int[][] UpdateMatrix(int[][] mat)
    {
        // Get the number of rows in the matrix
        int rowLength = mat.Length;
        // Get the number of columns in the matrix
        int colomnLength = mat[0].Length;
        // Calculate the maximum possible distance in the matrix
        int max = rowLength + colomnLength;

        // Iterate through each cell in the matrix
        for (int row = 0; row < rowLength; row++)
        {
            for (int column = 0; column < colomnLength; column++)
            {
                // If the current cell contains 0, skip it
                if (mat[row][column] == 0)
                {
                    continue;
                }

                // Initialize top and left distances to maximum
                int top = max;
                int left = max;

                // Update top distance if there's a non-zero cell above
                if (row > 0)
                {
                    top = mat[row - 1][column];
                }

                // Update left distance if there's a non-zero cell on the left
                if (column > 0)
                {
                    left = mat[row][column - 1];
                }

                // Update the current cell with the minimum distance from top or left plus 1
                mat[row][column] = Math.Min(top, left) + 1;
            }
        }

        // Iterate through each cell in reverse order
        for (int row = rowLength - 1; row >= 0; row--)
        {
            for (int column = colomnLength - 1; column >= 0; column--)
            {
                // If the current cell contains 0, skip it
                if (mat[row][column] == 0)
                {
                    continue;
                }

                // Initialize bottom and right distances to maximum
                int bottom = max;
                int right = max;

                // Update bottom distance if there's a non-zero cell below
                if (row < rowLength - 1)
                {
                    bottom = mat[row + 1][column];
                }

                // Update right distance if there's a non-zero cell on the right
                if (column < colomnLength - 1)
                {
                    right = mat[row][column + 1];
                }

                // Update the current cell with the minimum distance from bottom, right, or current value plus 1
                mat[row][column] = Math.Min(mat[row][column], Math.Min(bottom, right) + 1);
            }
        }
        // Return the updated matrix
        return mat;
    }
}
