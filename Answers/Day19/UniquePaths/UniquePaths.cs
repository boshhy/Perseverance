public class Solution
{
    // Method to calculate the number of unique paths from the top-left corner to the bottom-right corner of a grid of size m x n.
    public int UniquePaths(int m, int n)
    {
        // Create a Dictionary to store the number of unique paths for each cell.
        Dictionary<(int, int), int> grid = new Dictionary<(int, int), int>();

        // Initialize the first column with all cells having 1 unique path.
        for (int row = 0; row < m; row++)
        {
            grid[(row, 0)] = 1;
        }

        // Initialize the first row with all cells having 1 unique path.
        for (int column = 0; column < n; column++)
        {
            grid[(0, column)] = 1;
        }

        // Calculate the number of unique paths for each cell in the grid.
        for (int row = 1; row < m; row++)
        {
            for (int column = 1; column < n; column++)
            {
                // The number of unique paths to reach a cell is the sum of unique paths from the cell above and the cell to the left.
                grid[(row, column)] = grid[(row - 1, column)] + grid[(row, column - 1)];
            }
        }

        // Return the number of unique paths to reach the bottom-right corner of the grid.
        return grid[(m - 1, n - 1)];
    }
}
