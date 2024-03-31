// Overview
public class Solution
{
    public int UniquePaths(int m, int n)
    {
        // This code calculates the number of unique paths from the top-left corner to the bottom-right corner of a 
        // grid with dimensions m x n. It initializes a dictionary grid to store the number of paths for each cell. 
        // Then, it sets the number of paths for the first row and column to 1 since there is only one way to reach 
        // each cell in those rows/columns. Then, it iterates through the grid, updating the number of paths for 
        // each cell based on the sum of paths from the cell above and the cell to the left. 
        // Finally, it returns the number of unique paths to reach the bottom-right corner of the grid.
    }
}

// Comments
public class Solution
{
    // Method to calculate the number of unique paths from the top-left corner to the bottom-right corner of a grid of size m x n.
    public int UniquePaths(int m, int n)
    {
        // Create a Dictionary to store the number of unique paths for each cell.

        // Initialize the first column with all cells having 1 unique path.

        // Initialize the first row with all cells having 1 unique path.

        // Calculate the number of unique paths for each cell in the grid.
        //         The number of unique paths to reach a cell is the sum of unique paths from the cell above and the cell to the left.

        // Return the number of unique paths to reach the bottom-right corner of the grid.
    }
}

// Pseudocode
public class Solution
{
    public int UniquePaths(int m, int n)
    {
        // grid = Empty Dictionary

        // For row = 0 to m - 1:
        //     grid[(row, 0)] = 1

        // For column = 0 to n - 1:
        //     grid[(0, column)] = 1

        // For row = 1 to m - 1:
        //     For column = 1 to n - 1:
        //         grid[(row, column)] = grid[(row - 1, column)] + grid[(row, column - 1)]

        // Return grid[(m - 1, n - 1)]
    }
}
