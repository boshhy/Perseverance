// Overview
public class Solution
{
    public int NumIslands(char[][] grid)
    {
        // The provided code defines a class with a method NumIslands that counts the number of islands 
        // in a 2D grid represented by a char array. It iterates through each cell in the grid, and if 
        // the cell contains '1' (indicating land), it increments the total number of islands and recursively 
        // visits the island to mark all its connected land cells as visited. 
        // Finally, it returns the total count of islands found in the grid.
    }
}

// Comments
public class Solution
{
    // Method to count the number of islands in the given grid
    public int NumIslands(char[][] grid)
    {
        // Variable to store the total number of islands

        // Loop through each row in the grid
        //     Loop through each column in the grid
        //         If the cell contains '1', indicating land, increment totalIslands and visit the island
        //             Start visiting the island

        // Return the total number of islands found

        // Method to recursively visit all adjacent cells of an island and mark them as visited
        //     Base case: Check if the current cell is out of bounds or if it's water ('0')
        //         Return if out of bounds
        //         Return if the current cell is water

        //     Mark the current cell as visited by changing its value to '0'

        //     Visit adjacent cells recursively (up, down, left, right)
    }
}

// Pseudocode
public class Solution
{
    public int NumIslands(char[][] grid)
    {
        //     totalIslands = 0
        //     for each row in grid:
        //         for each column in row:
        //             if grid[row][column] == '1':
        //                 totalIslands++
        //                 VisitIsland(row, column)
        //     return totalIslands

        // function VisitIsland(r, c):
        //     if r < 0 or r >= grid.length or c < 0 or c >= grid[0].length:
        //         return
        //     if grid[r][c] == '0':
        //         return
        //     grid[r][c] = '0'
        //     VisitIsland(r + 1, c)
        //     VisitIsland(r, c + 1)
        //     VisitIsland(r - 1, c)
        //     VisitIsland(r, c - 1)
    }
}