// Overview
public class Solution
{
    public int OrangesRotting(int[][] grid)
    {
        // This code implements a function OrangesRotting that calculates the minimum time required to rot all oranges in a grid. 
        // It iterates through the grid, counting fresh oranges and enqueuing rotten ones. Then, it continuously processes 
        // rotten oranges and their adjacent fresh oranges until either all fresh oranges are rotten or no further rotten oranges 
        // are adjacent to fresh ones. It returns the minimum time taken to rot all oranges, or -1 if not all oranges can be rotten.
    }
}

// Comments
public class Solution
{
    // Method to find the minimum time required to rot all oranges in the grid
    public int OrangesRotting(int[][] grid)
    {
        // Variable to keep track of total fresh oranges
        // Variable to store the number of minutes passed

        // Queue to store the positions of rotten oranges

        // Loop through the grid to count fresh oranges and enqueue rotten oranges
        // Loop through each row in the grid
        //     Loop through each column in the grid
        //         If the current cell has a fresh orange, increment totalFreshOranges
        //         If the current cell has a rotten orange, enqueue its position

        // While there are rotten oranges in the queue and fresh oranges remaining
        //     Count the number of rotten oranges in the current minute

        //     Process all rotten oranges in the current minute
        //         Dequeue the position of a rotten orange

        //         Add adjacent fresh oranges to the queue and mark them as rotten
        //     Increment the minute counter

        // If all fresh oranges are rotten, return the number of minutes passed
        // Otherwise, return -1 indicating that not all oranges can be rotten


        // Method to add adjacent fresh oranges to the queue and mark them as rotten
        //     Check if the position is within the grid boundaries
        //     If the adjacent cell has a fresh orange
        //         Mark it as rotten and enqueue its position
        //         Decrement the count of total fresh oranges
        //         Enqueue the position of the newly rotten orange
    }
}


// Pseudocode
public class Solution
{
    public int OrangesRotting(int[][] grid)
    {
        // totalFreshOranges = 0
        // minutesPassed = 0
        // queue = empty Queue

        // for each row in grid:
        //     for each column in row:
        //         if grid[row][column] == 1:
        //             totalFreshOranges++
        //         if grid[row][column] == 2:
        //             enqueue (row, column) to queue

        // while queue is not empty and totalFreshOranges > 0:
        //     rottenCount = size of queue

        //     for i = 1 to rottenCount:
        //         (row, column) = dequeue from queue

        //         AddAdjacentOranges(row + 1, column)
        //         AddAdjacentOranges(row, column + 1)
        //         AddAdjacentOranges(row - 1, column)
        //         AddAdjacentOranges(row, column - 1)

        //     minutesPassed++

        // return (totalFreshOranges == 0) ? minutesPassed : -1

        // function AddAdjacentOranges(r, c):
        //     if r < 0 or r >= number of rows in grid or c < 0 or c >= number of columns in grid:
        //         return
        //     if grid[r][c] == 1:
        //         mark grid[r][c] as 2
        //         decrement totalFreshOranges
        //         enqueue (r, c) to queue
    }
}