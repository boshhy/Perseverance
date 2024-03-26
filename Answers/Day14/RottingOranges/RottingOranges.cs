public class Solution
{
    // Method to find the minimum time required to rot all oranges in the grid
    public int OrangesRotting(int[][] grid)
    {
        // Variable to keep track of total fresh oranges
        int totalFreshOranges = 0;
        // Variable to store the number of minutes passed
        int minutesPassed = 0;

        // Queue to store the positions of rotten oranges
        Queue<(int, int)> queue = new Queue<(int, int)>();

        // Loop through the grid to count fresh oranges and enqueue rotten oranges
        // Loop through each row in the grid
        for (int row = 0; row < grid.Length; row++)
        {
            // Loop through each column in the grid
            for (int column = 0; column < grid[0].Length; column++)
            {
                // If the current cell has a fresh orange, increment totalFreshOranges
                if (grid[row][column] == 1)
                {
                    totalFreshOranges++;
                }
                // If the current cell has a rotten orange, enqueue its position
                if (grid[row][column] == 2)
                {
                    queue.Enqueue((row, column));
                }
            }
        }

        // While there are rotten oranges in the queue and fresh oranges remaining
        while (queue.Count != 0 && totalFreshOranges > 0)
        {
            // Count the number of rotten oranges in the current minute
            int rottenCount = queue.Count;

            // Process all rotten oranges in the current minute
            for (int i = 0; i < rottenCount; i++)
            {
                // Dequeue the position of a rotten orange
                (int row, int column) = queue.Dequeue();

                // Add adjacent fresh oranges to the queue and mark them as rotten
                AddAdjacentOranges(row + 1, column);
                AddAdjacentOranges(row, column + 1);
                AddAdjacentOranges(row - 1, column);
                AddAdjacentOranges(row, column - 1);
            }
            // Increment the minute counter
            minutesPassed++;
        }

        // If all fresh oranges are rotten, return the number of minutes passed
        // Otherwise, return -1 indicating that not all oranges can be rotten
        return (totalFreshOranges == 0) ? minutesPassed : -1;


        // Method to add adjacent fresh oranges to the queue and mark them as rotten
        void AddAdjacentOranges(int r, int c)
        {
            // Check if the position is within the grid boundaries
            if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length)
            {
                return;
            }
            // If the adjacent cell has a fresh orange
            if (grid[r][c] == 1)
            {
                // Mark it as rotten and enqueue its position
                grid[r][c] = 2;
                // Decrement the count of total fresh oranges
                totalFreshOranges--;
                // Enqueue the position of the newly rotten orange
                queue.Enqueue((r, c));
            }
        }

    }
}
