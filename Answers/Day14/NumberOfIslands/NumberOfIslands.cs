public class Solution
{
    // Method to count the number of islands in the given grid
    public int NumIslands(char[][] grid)
    {
        // Variable to store the total number of islands
        int totalIslands = 0;

        // Loop through each cell in the grid
        for (int row = 0; row < grid.Length; row++)
        {
            for (int column = 0; column < grid[0].Length; column++)
            {
                // If the cell contains '1', indicating land, increment totalIslands and visit the island
                if (grid[row][column] == '1')
                {
                    totalIslands++;
                    VisitIsland(row, column); // Start visiting the island
                }
            }
        }

        // Return the total number of islands found
        return totalIslands;

        // Method to recursively visit all adjacent cells of an island and mark them as visited
        void VisitIsland(int r, int c)
        {
            // Base case: Check if the current cell is out of bounds or if it's water ('0')
            if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length)
            {
                return; // Return if out of bounds
            }
            if (grid[r][c] == '0')
            {
                return; // Return if the current cell is water
            }

            // Mark the current cell as visited by changing its value to '0'
            grid[r][c] = '0';

            // Visit adjacent cells recursively (up, down, left, right)
            VisitIsland(r + 1, c); // Visit cell below
            VisitIsland(r, c + 1); // Visit cell to the right
            VisitIsland(r - 1, c); // Visit cell above
            VisitIsland(r, c - 1); // Visit cell to the left
        }
    }
}
