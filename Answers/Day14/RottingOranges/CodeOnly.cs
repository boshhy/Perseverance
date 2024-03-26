public class Solution
{
    public int OrangesRotting(int[][] grid)
    {
        int totalFreshOranges = 0;
        int minutesPassed = 0;

        Queue<(int, int)> queue = new Queue<(int, int)>();

        for (int row = 0; row < grid.Length; row++)
        {
            for (int column = 0; column < grid[0].Length; column++)
            {
                if (grid[row][column] == 1)
                {
                    totalFreshOranges++;
                }
                if (grid[row][column] == 2)
                {
                    queue.Enqueue((row, column));
                }
            }
        }

        while (queue.Count != 0 && totalFreshOranges > 0)
        {
            int rottenCount = queue.Count;

            for (int i = 0; i < rottenCount; i++)
            {
                (int row, int column) = queue.Dequeue();

                AddAdjacentOranges(row + 1, column);
                AddAdjacentOranges(row, column + 1);
                AddAdjacentOranges(row - 1, column);
                AddAdjacentOranges(row, column - 1);
            }
            minutesPassed++;
        }

        return (totalFreshOranges == 0) ? minutesPassed : -1;


        void AddAdjacentOranges(int r, int c)
        {
            if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length)
            {
                return;
            }
            if (grid[r][c] == 1)
            {
                grid[r][c] = 2;
                totalFreshOranges--;
                queue.Enqueue((r, c));
            }
        }

    }
}